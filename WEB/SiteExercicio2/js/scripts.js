$(document).ready(
    function () {

        $('input[name="bntconverter"]').click(function () {

    var address = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";
    $.getJSON(address, function (data) {
        var valdolar = data.value[0].cotacaoVenda;
        var cvalor = $('input[name="reais"]').val()
            .replace(".", "").replace(".", "").replace(",", ".");
        var conversao = (cvalor / valdolar)
            .toLocaleString('en-US', { minimumFractionDigits: 2, currency: 'USD' });    
        $('input[name="dolares"]').val(conversao);
            //$('input[name="reais"]').mask("000.000,00")
        });
    });
        $('input[name="valoreal"]').maskMoney({
            showSymbol: false,
            symbol: "R$",
            decimal: ",",
            thousands: "."
        });
    }
);






//$(document).ready(function () {
//    $('input[name="reais"]').maskMoney({ showSymbol: true, symbol: "R$", decimal: ",", thousands: "." });
//}) /*retornando NaN se passar a mascara*/

