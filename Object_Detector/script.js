const video = document.getElementById('webcam');
const canvas = document.getElementById('canvas');
const ctx = canvas.getContext('2d');
const objectCountBox = document.getElementById('object-count');
let model;
let lastSpoken = '';

async function setupCamera() {
  try {
    const stream = await navigator.mediaDevices.getUserMedia({ video: true });
    video.srcObject = stream;
    return new Promise(resolve => {
      video.onloadedmetadata = () => {
        video.play();
        resolve();
      };
    });
  } catch (err) {
    console.error("Camera access denied or error:", err);
  }
}

function speak(text) {
  if ('speechSynthesis' in window && text !== lastSpoken) {
    const utter = new SpeechSynthesisUtterance(text);
    utter.pitch = 0.8;         // Softer tone
    utter.rate = 0.85;         // Slower pace
    utter.lang = 'en-US';      // English US
    speechSynthesis.speak(utter);
    lastSpoken = text;
  }
}

function updateObjectCount(predictions) {
  const counts = {};
  predictions.forEach(pred => {
    counts[pred.class] = (counts[pred.class] || 0) + 1;
  });

  const entries = Object.entries(counts);
  const display = entries.map(([cls, count]) => `${count} × ${cls}`).join(' • ');
  objectCountBox.textContent = display || 'No objects detected';

  if (entries.length > 0) {
    const spokenText = entries.map(([cls, count]) => `${count} ${cls}${count > 1 ? 's' : ''}`).join(', ');
    speak(`Detected ${spokenText}`);
  }
}

async function detectFrame() {
  if (!model || video.readyState !== 4) {
    requestAnimationFrame(detectFrame);
    return;
  }

  const predictions = await model.detect(video);
  canvas.width = video.videoWidth;
  canvas.height = video.videoHeight;

  ctx.clearRect(0, 0, canvas.width, canvas.height);
  ctx.drawImage(video, 0, 0, canvas.width, canvas.height);

  predictions.forEach(pred => {
    const [x, y, width, height] = pred.bbox;
    ctx.strokeStyle = '#ff69b4';
    ctx.lineWidth = 2;
    ctx.strokeRect(x, y, width, height);

    ctx.font = '16px Segoe UI';
    ctx.fillStyle = '#ffe4f4';
    ctx.fillText(`${pred.class} (${Math.round(pred.score * 100)}%)`, x + 5, y + 20);
  });

  updateObjectCount(predictions);
  requestAnimationFrame(detectFrame);
}

async function main() {
  model = await cocoSsd.load();
  await setupCamera();
  detectFrame();
}

main();