//$(document).ready(function () {
//    $('button[name="btnBoasVindas"]').click(function () {
//        var nomeusuario = $('input[name="myname"]').val();
//        $('span[name="usuariotext"]').text(nomeusuario);
//    });
//});/* $(document).ready( >>>>>> apenas após carregar o site por completo, executa o conteudo do script*/
//$(document).on('keypress', function (e) {
//    if (e.which === 13) {
//        $('input[name="myname]"').click();
//    }
//});
// carrega as funções após carregar a página.
$(document).ready(function () {
    $('button[name=btnBoasVindas]').click(function () {
        var nomeusuario = $('input[name="myname"]').val();
        $('span[name="usuariotext"]').text(nomeusuario);
    });
});


//habilita o ENTER para executar o evento.
$(document).on('keypress', function (e) {
    if (e.which == 13) {
        $('button[name="btnboasvindas"]').click();
    }
});


/*sem usar document.ready*/
//function bvindas() {
//    var gname = document.getElementById("myname").value;
//    alert('Bem Vindo ' + gname);
//    $('span[name="usuariotext"]').text(nomeusuario);
//}