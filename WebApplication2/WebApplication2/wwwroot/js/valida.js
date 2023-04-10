function validarCpfCnpj(valor) {
    var cpf = valor.replace(/[^\d]+/g, '');
    var cnpj = valor.replace(/[^\d]+/g, '');

    if (cpf.length == 0) && (cnpj.length == ){
        alert('o Campo CPF e/ou CPNJ não pode ser vazio.');
    }

    if (cpf.length != 11) && (cnpj.length != 14){
        alert('CPF e ou CNPK inválido. O CPF deve ter 11 dígitos e/ou CNPJ deve ter 14 dígitos.');
    }
    
    // Valida CPF
    if (cpf.length == 11) {
        var allEqual = true;
        for (var i = 1; i < cpf.length; i++) {
            if (cpf[i] != cpf[0]) {
                allEqual = false;
                break;
            }
        }
        if (allEqual) {
            alert('CPF inválido. O CPF não pode ter todos os dígitos iguais.');
            return false;
        }
        // Validação dos dígitos verificadores
        var soma = 0;
        var resto;
        for (var i = 1; i <= 9; i++) soma = soma + parseInt(cpf.substring(i - 1, i)) * (11 - i);
        resto = (soma * 10) % 11;
        if ((resto == 10) || (resto == 11)) resto = 0;
        if (resto != parseInt(cpf.substring(9, 10))) {
            alert('CPF inválido. O primeiro dígito verificador está incorreto.');
            return false;
        }
        soma = 0;
        for (var i = 1; i <= 10; i++) soma = soma + parseInt(cpf.substring(i - 1, i)) * (12 - i);
        resto = (soma * 10) % 11;
        if ((resto == 10) || (resto == 11)) resto = 0;
        if (resto != parseInt(cpf.substring(10, 11))) {
            alert('CPF inválido. O segundo dígito verificador está incorreto.');
            return false;
        }
        // CPF válido
        alert('CPF válido!');
        return true;
    }
    }
    // Valida CNPJ
    if (cnpj.length == 14) {
        if (cnpj == "00000000000000" ||
            cnpj == "11111111111111" ||
            cnpj == "22222222222222" ||
            cnpj == "33333333333333" ||
            cnpj == "44444444444444" ||
            cnpj == "55555555555555" ||
            cnpj == "66666666666666" ||
            cnpj == "77777777777777" ||
            cnpj == "88888888888888" ||
            cnpj == "99999999999999") {
            alert("CNPJ inválido");
            document.getElementById("cpf-Cnpj").focus();
            return false;
            }
        var tamanho = cnpj.length - 2;
        var numeros = cnpj.substring(0, tamanho);
        var digitos = cnpj.substring(tamanho);
        var soma = 0;
        var pos = tamanho - 7;
        for (var i = tamanho; i >= 1; i--) {
            soma += numeros.charAt(tamanho - i) * pos--;
            if (pos < 2)
                pos = 9;
        }
        var resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
        if (resultado != digitos.charAt(0)) {
            alert("CNPJ inválido");
            document.getElementById("cpf-Cnpj").focus();
            return false;
        }

    }
}




