﻿$(document).ready(function () {
    $('input[name="bt1"]').on('click', function () {
        var apeso = $('input[name="peso"]').val();
        var anome = $('input[name="nome"]').val();
        var aaltura = $('input[name="altura"]').val();
        $.get("http://localhost:60212/Api/CalculoIdade?peso=" + apeso + "&altura=" + aaltura + "&nome=" + anome, function (data) {
            console.log(data);
            $('input[name="nome"]').val(data.nome);
            $('input[name="altura"]').val(data.altura);
            $('input[name="peso"]').val(data.peso);
           
            var imc = data.split(":")[1]; 
            $('input[name="meuimc"]').val(imc);
            alert(data);
           
        });
    });
});
//$('input[name="bt1"]').on('click', function () {
//    var informacoes = $('form[name="formenviar"]').serializeArray();
//    var obterAtributo = $('form[name="formenviar"]').attr('send-post');

//    $.post("http://localhost:60212/Api/" + obterAtributo, informacoes, function (data) {
//        data = JSON.parse(data);
//        console.log(data);
                  
//            $('span[name="meuimc"]').val();
        
//    });
//});
//});