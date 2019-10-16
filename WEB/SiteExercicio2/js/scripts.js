function bvindas() {
    var cvalor = document.getElementById("reais").value;
    alert('Convertendo para Dolar Comercial a 4.05:' + '-+-+-+- Total em dolar: ' + cvalor / 4.05)
    
}
function convertendo() {
    var fvalor = document.getElementById("reais").value / 4.00;  
}
function convertREAL() {
    var cvalor = (parseFloat(document.getElementById("reais").value / 4.05)).toFixed(2);
    $('input[id="money"]').val(cvalor);

}