$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var newCEP = $('input[name="newCEP"]').val();
                if (newCEP.length < 9) { alert("Formato inválido de CEP."); }
                else {
                    $.get("https://viacep.com.br/ws/" + newCEP + "/json/", function (data, status) {
                        console.log(data)
                        if (data.erro != true) {
                            $('input[name="bairro"]').val(data.bairro)
                            $('input[name="localidade"]').val(data.localidade)
                            $('input[name="logradouro"]').val(data.logradouro)
                            $('input[name="complemento"]').val(data.complemento)
                            $('input[name="cep"]').val(data.cep)
                            $('input[name="uf"]').val(data.uf)
                            $('input[name="ibge"]').val(data.ibge)
                            $('input[name="gia"]').val(data.gia)
                        }
                        else {
                            alert("CEP inválido ou não encontrado.");
                        }
                    });
                }
            }
        );

    });
function LimparTela() {
    var meusInputs = $('input[type="text"]');
    meusInputs.val("");
}
$(document).on('keypress', function (e) {
    if (e.which == 13) {
        $('input[type="button"]').click();
    }
});