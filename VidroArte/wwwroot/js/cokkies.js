
startTimer();
document.addEventListener('mousemove', resetTimer);
document.addEventListener('keypress', resetTimer);
function startTimer() {
    timeoutId = setTimeout(logout, 300000); // timeout de 5 minuto
}

function resetTimer() {
    clearTimeout(timeoutId);
    startTimer();
}