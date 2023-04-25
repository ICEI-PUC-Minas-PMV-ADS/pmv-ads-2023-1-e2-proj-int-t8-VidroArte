var $table = $('#table');
$(function () {
    $('#toolbar').find('select').change(function () {
        $table.bootstrapTable('refreshOptions', {
            exportDataType: $(this).val()
        });
    });
})

var trBoldBlue = $("table");

$(trBoldBlue).on("click", "tr", function () {
    $(this).toggleClass("bold-blue");
});

async function procClientes() {
    const res = await fetch('/json/usuarios.json');
    const clientes = await res.json();
    var lista="";

    for (let i = 0; i < clientes.length; i++) {
        lista += "<tr><td>" + clientes[i].nome + "</td><td>" +
            clientes[i].cpf + "</td><td>" +
            clientes[i].email + "</td><td>" +
            clientes[i].telefone + "</td><td>" +
            clientes[i].senha + "</td></tr>";
    }

    document.getElementById('saida_clientes').innerHTML = lista;
}
