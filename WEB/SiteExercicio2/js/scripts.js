function bvindas() {
    var cvalor = document.getElementById("reais").value;
    alert('Convertendo para Dolar Comercial a 4.05:' + '-+-+-+- Total em dolar: ' + cvalor / 4.05)
    
}
function convertendo() {
    var fvalor = document.getElementById("reais").value / 4.00;  
}
function convertREAL() {
    var cvalor = (parseFloat(document.getElementById("reais").value / 4.05))
        //.replace(".","")
        //.replace(".", "")
        .toFixed(2);
    $('input[id="money"]').val(cvalor);
    //$('input[name="reais"]').mask("000.000,00")
}