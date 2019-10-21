/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/

$(document).ready(
    function () {
        $('button[name="bntmostrar"]').click(function () {
            $('input[name="vNome"]').val("Sauro");
            $('input[name="vIdade"]').val(5);
            $('input[name="vRaca"]').val("Vira Lata");
            $('input[name="vColor"]').val("Caramelo queimado");
        });

        $('button[name="bntsalvar"]').click(function () {
            var mnome = $('input[name="vNome"]').val();
            var midade = $('input[name="vIdade"]').val();
            var mraca = $('input[name="vRaca"]').val();
            var mcor = $('input[name="vColor"]').val();
            $('span[name="mnome"]').text(mnome);
            $('span[name="midade"]').text(midade);
            $('span[name="mraca"]').text(mraca);
            $('span[name="mcor"]').text(mcor);
        });
    }
);
function LimparTela() {
    var meusInputs = $('input[type="text"]');    
        meusInputs.val("");    
}


//$(document).on('keypress', function (e) {
//    if (e.which == 13) {
//        $('button[name="btnboasvindas"]').click();
//    }
//});
