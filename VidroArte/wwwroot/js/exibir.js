$(document).ready(function () {
    $('input:checkbox[name="cadbanco"]').on("change", function () {
        if (this.checked == true) {
            $("#banco, #agencia, #conta, #tipoconta,#digito,#linhabanco").show();
            $('#banco').prop('required', true);
            $('#agencia').prop('required', true);
            $('#conta').prop('required', true);
            $('#digito').prop('required', true);
            $('#tipoconta').prop('required', true);

        } else {
            $("#banco, #agencia, #conta, #tipoconta,#digito,#linhabanco").hide();
            $('#banco').prop('required', false);
            $('#agencia').prop('required', false);
            $('#conta').prop('required', false);
            $('#digito').prop('required', false);
            $('#tipoconta').prop('required', false);
        }
    });
});
$(document).ready(function () {
    $('input:radio[name="cnpjcpf"]').on("change", function () {
        if (this.checked && this.value == 'cpf') {
            $("#nome, #rg, #dtnascimento").show();
            $("#inscestadual, #ufinsc, #razaosocial, #responsavel").hide();
            $('#nome').prop('required', true);
            $('#cpf').prop('required', true);
            $('#rg').prop('required', true);
            $('#dtnascimento').prop('required', true);
            $('#cnpj').prop('required', false);
            $('#razaosocial').prop('required', false);
            $('#responsavel').prop('required', false);

        } else {
            $("#inscestadual, #ufinsc, #cnpj, #razaosocial, #responsavel").show();
            $("#nome, #cpf, #rg, #dtnascimento").hide();
            $('#nome').prop('required', false);
            $('#cpf').prop('required', false);
            $('#rg').prop('required', false);
            $('#dtnascimento').prop('required', false);
            $('#cnpj').prop('required', true);
            $('#razaosocial').prop('required', true);
            $('#responsavel').prop('required', true);
        }
    });
});
$(document).ready(function () {
    $('input:checkbox[name="sistema"]').on("change", function () {
        if (this.checked == true) {
            $("#usuario, #senha,#linhasistema").show();
            $('#usuario').prop('required', true);
            $('#senha').prop('required', true);
            linhasistema
        } else {
            $("#usuario, #senha,#linhasistema").hide();
            $('#usuario').prop('required', false);
            $('#senha').prop('required', false);
        }
    });
});