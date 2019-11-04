/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
$(document).ready(
    function () {
        $('button[name="bntmostrar"]').click(function () {
            $('input[name="vMarca"]').val("GTX");
            $('input[name="vValor"]').val(555);
            $('input[name="vPeso"]').val(7);            
        });

        $('button[name="bntsalvar"]').click(function () {
            var mnmarca = $('input[name="vMarca"]').val();
            var mvalor = $('input[name="vValor"]').val();
            var mpeso = $('input[name="vPeso"]').val();          
            $('span[name="mmarca"]').text(mnmarca);
            $('span[name="mvalor"]').text(mvalor);
            $('span[name="mpeso"]').text(mpeso);
         
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
