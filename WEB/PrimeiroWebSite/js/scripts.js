$(document).ready(
    function () {
        /*set*/
        atualizaData();
    });
/*criamos nossa primeira funcao*/
function atualizaData() {
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 1000);
    }