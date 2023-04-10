function validarCpfCnpj(valor) {
    var dados = valor.replace(/[^\d]+/g, '')
            // Valida CPF
            if (dados.length == 11) {
                var allEqual = true;
                for (var i = 1; i < dados.length; i++) {
                    if (dados[i] != dados[0]) {
                        allEqual = false;
                        break;
                    }
                }
                if (allEqual) {
                    alert('CPF inválido. O CPF não pode ter todos os dígitos iguais.');
                    document.getElementById("cpf-Cnpj").value = '';
                    return false;
                }
                // Validação dos dígitos verificadores
                var soma = 0;
                var resto;
                for (var i = 1; i <= 9; i++) soma = soma + parseInt(dados.substring(i - 1, i)) * (11 - i);
                resto = (soma * 10) % 11;
                if ((resto == 10) || (resto == 11)) resto = 0;
                if (resto != parseInt(dados.substring(9, 10))) {
                    alert('CPF inválido. O primeiro dígito verificador está incorreto.');
                    document.getElementById("cpf-Cnpj").value = '';
                    return false;
                }
                soma = 0;
                for (var i = 1; i <= 10; i++) soma = soma + parseInt(dados.substring(i - 1, i)) * (12 - i);
                resto = (soma * 10) % 11;
                if ((resto == 10) || (resto == 11)) resto = 0;
                if (resto != parseInt(dados.substring(10, 11))) {
                    alert('CPF inválido. O segundo dígito verificador está incorreto.');
                    document.getElementById("cpf-Cnpj").value='';
                    return false;
                }

            }
            // Valida CNPJ
            else if (dados.length == 14)
                 {
                    if (dados == "00000000000000" ||
                        dados == "11111111111111" ||
                        dados == "22222222222222" ||
                        dados == "33333333333333" ||
                        dados == "44444444444444" ||
                        dados == "55555555555555" ||
                        dados == "66666666666666" ||
                        dados == "77777777777777" ||
                        dados == "88888888888888" ||
                        dados == "99999999999999")
                            {
                                alert("O CNPJ informado é inválido.");
                        document.getElementById("cpf-Cnpj").value = '';
                                return false;
                            }

                        // Valida DVs
                        tamanho = dados.length - 2
                        numeros = dados.substring(0, tamanho);
                        digitos = dados.substring(tamanho);
                        soma = 0;
                        pos = tamanho - 7;
                        for (i = tamanho; i >= 1; i--) {
                            soma += numeros.charAt(tamanho - i) * pos--;
                            if (pos < 2)
                                pos = 9;
                        }
                        resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                        if (resultado != digitos.charAt(0)) {
                            alert("O CNPJ informado é inválido.");
                            document.getElementById("cpf-Cnpj").value = '';
                            return false;
                        }

                        tamanho = tamanho + 1;
                        numeros = dados.substring(0, tamanho);
                        soma = 0;
                        pos = tamanho - 7;
                        for (i = tamanho; i >= 1; i--) {
                            soma += numeros.charAt(tamanho - i) * pos--;
                            if (pos < 2)
                                pos = 9;
                        }
                        resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                        if (resultado != digitos.charAt(1)) {
                            alert("O CNPJ informado é inválido.");
                            document.getElementById("cpf-Cnpj").value = '';
                            return false;
                        }

                if (verificaCNPJAtivo(dados)) {
                    alert("CNPJ ATIVO");
                } else {
                    alert("CNPJ não está ativo.");
                } 

            }

            else
                {
                    if (dados != '') {
                        alert('o Valor digitado não e CPF e/ou CNPJ');
                        document.getElementById("cpf-Cnpj").value = '';
                    }
                 }
                    
     
}


function Verificacheck(valor) {
    var tipo = document.querySelector('input[name=cnpjcpf]:checked').value;
    var dados = valor.replace(/[^\d]+/g, '')

    if ((tipo == "cpf") && (dados.length == 14)) {
        alert('Favor informar um cpf ou selecionar que está informando dados de pessoa Juridica ');
        document.getElementById("cpf-Cnpj").value = '';
    }
    else if ((tipo == "cnpj") && (dados.length == 11)) {
        alert('Favor informar um cnpj ou selecionar que está informando dados de pessoa Fisica');
        document.getElementById("cpf-Cnpj").value = '';
    }
    else {
        validarCpfCnpj(dados);

    }
}

$(document).ready(function () {
    $('input:radio[name="cnpjcpf"]').on("change", function () {

        var tipo1 = document.querySelector('input[name=cnpjcpf]:checked').value;

        if (tipo1 == "cpf") {
            alert('Seleção alterada de Pessoa Juridica para Pessoa fisica, favor informar o CPF');
            document.getElementById("cpf-Cnpj").value = '';
        }
        else if (tipo1 == "cnpj") {
            alert('Seleção alterada de Pessoa fisica para Pessoa Juridica, favor informar o CNPJ');
            
            document.getElementById("cpf-Cnpj").value = '';
        }

    });
});








async function verificaCNPJAtivo(cnpj) {
    const puppeteer = require('puppeteer');
    const browser = await puppeteer.launch();
    const page = await browser.newPage();
    await page.goto(`https://www.receitaws.com.br/v1/cnpj/${cnpj}`);

    const resultado = await page.evaluate(() => {
        const status = document.querySelector('#situacao').innerText;
        return status === 'ATIVA';
    });

    await browser.close();

    return resultado;
}