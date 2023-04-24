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
    var $seuCampoPix = $("#pix");
    $seuCampoPix.mask('000.000.000,00', { reverse: true }).on('focusout', function () {
        var valorAtual = $(this).val();
        if (valorAtual !== "" && !valorAtual.startsWith("R$ ")) {
            $(this).val('R$ ' + valorAtual);
        }
    });
});

$(document).ready(function () {
    var $seuCampocredito = $("#credito");
    $seuCampocredito.mask('000.000.000,00', { reverse: true }).on('focusout', function () {
        var valorAtual = $(this).val();
        if (valorAtual !== "" && !valorAtual.startsWith("R$ ")) {
            $(this).val('R$ ' + valorAtual);
        }
    });
});

$(document).ready(function () {
    var $seuCampodebito = $("#debito");
    $seuCampodebito.mask('000.000.000,00', { reverse: true }).on('focusout', function () {
        var valorAtual = $(this).val();
        if (valorAtual !== "" && !valorAtual.startsWith("R$ ")) {
            $(this).val('R$ ' + valorAtual);
        }
    });
});


$(document).ready(function () {
    var $seuCampoDinheiro = $("#dinheiro");
    $seuCampoDinheiro.mask('000.000.000,00', { reverse: true }).on('focusout', function () {
        var valorAtual = $(this).val();
        if (valorAtual !== "" && !valorAtual.startsWith("R$ ")) {
            $(this).val('R$ ' + valorAtual);
        }
    });
});