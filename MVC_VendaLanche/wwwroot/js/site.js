let count = 0;
function addOne(lancheId) {
    var counter = document.getElementById("counter-" + lancheId);
    var currentValue = parseInt(counter.textContent);
    counter.textContent = currentValue + 1;
}

function removeOne(lancheId) {
    var counter = document.getElementById("counter-" + lancheId);
    var currentValue = parseInt(counter.textContent);
    if (currentValue > 0) {
        counter.textContent = currentValue - 1;
    }
}

function updateCounter() {
    document.getElementById("counter").textContent = count; // Atualiza o valor do contador na tela
}

