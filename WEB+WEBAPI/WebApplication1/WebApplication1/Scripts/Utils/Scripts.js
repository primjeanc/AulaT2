$(document).ready(function () {
    $('#button1').click(function () {
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {
            var templateContent = '';

            templateContent += '<div><table class="table"><tbody>' +
                '<th>Valor</th>' +
                '<th>Localidade</th>' +
                '<th>Código CEP</th>' +
                '<th>Logradouro</th>' +
                '<th>Bairro</th>' +
                '<th>IBGE</th>' +
                '<th>GIA</th>' +
                '<th>Complemento</th>' +

                '<td>';

            $.each(data, function (key, value) {
                templateContent += "<tr><td>" + key + "</td> "
                    + "<td>" + value.localidade + "</td>"
                    + "<td style='width:40px'>" + value.cep + "</td>"
                    + "<td>" + value.logradouro + "</td>"
                    + "<td>" + value.bairro + "</td>"
                    + "<td>" + value.ibge + "</td>"
                    + "<td>" + value.gia + "</td>"
                    + "<td>" + value.complemento + "</td></tr>";
            });
            $('#divContent').append("" + templateContent + "");
            templateContent += '</td></tbody><table></div>';

            //$.each(data, function (key, value) {

            //        var templateContent = "";
            //    templateContent += "{";
            //    $.each(value, function (key, value) {
            //            <tbody>
            //            <tr>
            //                "<td>"+key+"</td>",
            //            "<td>"+value.cep+"</td>",
            //            "<td>"+value.localidade+"</td>",
            //            "<td>"+value.bairro+"</td>",
            //            "<td>"+value.bairrologradouro+"</td>"
            //        </tr>
            //            </tbody>

            //templateContent += key + ": " + value.bairro + ";";            
        });
        //templateContent += "}, ";
        ////$('#divContent').append(
        ////    "<textarea>" + templateContent + "</textarea>"
        ////    );
        //    $('#divContent').append(
        //        "alert('" + templateContent + "')\">" + value.bairro
        //    );
    });
});
         
//$(document).ready(function () {
//                        $('#myTable').DataTable();
//                    });