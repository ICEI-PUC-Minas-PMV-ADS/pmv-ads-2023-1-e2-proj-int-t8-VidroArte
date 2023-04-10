function mascaraCpfCnpj(input) {
    var value = input.value;

    // Remove caracteres não-numéricos
    value = value.replace(/\D/g, '');

    // Verifica se é CPF ou CNPJ
    if (value.length <= 11) {
        // Coloca ponto entre o terceiro e o quarto dígitos
        value = value.replace(/(\d{3})(\d)/, '$1.$2');

        // Coloca ponto entre o sexto e o sétimo dígitos
        value = value.replace(/(\d{3})(\d)/, '$1.$2');

        // Coloca hífen entre o nono e o décimo dígitos
        value = value.replace(/(\d{3})(\d{1,2})$/, '$1-$2');

    } else {
        // Coloca ponto entre o segundo e o terceiro dígitos
        value = value.replace(/^(\d{2})(\d)/, '$1.$2');

        // Coloca ponto entre o quinto e o sexto dígitos
        value = value.replace(/^(\d{2})\.(\d{3})(\d)/, '$1.$2.$3');

        // Coloca barra entre o oitavo e o nono dígitos
        value = value.replace(/\.(\d{3})(\d)/, '.$1/$2');

        // Coloca hífen entre o penúltimo e o último dígitos
        value = value.replace(/(\d{4})(\d)/, '$1-$2');
    }

    // Devolve o valor formatado
    input.value = value;
}
$(document).ready(function () {
    var $seuCampoCep = $("#cep");
    $seuCampoCep.mask('00000-000', { reverse: true });
});
$(document).ready(function () {
    var $seuCampoCelular = $("#celular");
    $seuCampoCelular.mask('(00) 00000-0000', { reverse: false });
});
$(document).ready(function () {
    var $seuCampotelefone = $("#telefone");
    $seuCampotelefone.mask('(00) 0000-0000', { reverse: false });
});
$(document).ready(function () {
    var $seuCampodtnascimento = $("#dtnascimento");
    $seuCampodtnascimento.mask('00/00/0000', { reverse: true });
    var $seuCampodtnascimento = $("#fdtcontratacao");
    $seuCampodtnascimento.mask('00/00/0000', { reverse: true });
});
$(document).ready(function () {
    var $seuCamposalario = $("#salario");
    $seuCamposalario.mask('R$ 000.000,00', { reverse: true });
});

$(document).ready(function () {
    var $seuCampovalorservico = $("#valorservico");
    $seuCampovalorservico.mask('000.000.000,00', { reverse: true });
    $seuCampovalorservico.on('keyup', function (event) {
        var valor = $(this).val().replace(/\D/g, '');
        valor = (valor / 100).toFixed(2).replace('.', ',').replace(/(\d)(?=(\d{3})+\,)/g, "$1.");
        if (valor === '0,00') {
            $(this).val('');
        } else {
            $(this).val('R$ ' + valor);
        }
    });
});