    $(document).ready(function () {
            var $tableBody = $('tbody');
    var $emptyRow = $tableBody.find('tr:first').clone();
    $tableBody.find('tr:first input').val('');

    $('button[type="submit"]').on('click', function (e) {
        e.preventDefault();
    var $newRow = $emptyRow.clone();
    $newRow.find('input').val('');
    $tableBody.append($newRow);
                if ($tableBody.find('tr').length > 1) {
        $tableBody.find('button.delete-row').eq(0).addClass('delete-row');
                } else {
        $tableBody.find('button.delete-row').eq(0).removeClass('delete-row');
                }
            });

    $tableBody.on('click', '.delete-row', function () {
                var $row = $(this).closest('tr');
    var index = $row.index();
    if (index !== 0) {
        $row.remove();
                } else {
                    if ($tableBody.find('tr').length > 1) {
        $row.remove();
    $tableBody.find('button.delete-row').eq(0).addClass('delete-row');
                    } else {
        $tableBody.find('button.delete-row').eq(0).removeClass('delete-row');
                    }
                }
            });

    $tableBody.on('click', 'tr:first-child', function (e) {
                if (!$(this).hasClass('delete-row')) {
                    return;
                }

    var $row = $(this);
    var index = $row.index();
    if (index !== 0) {
        $row.remove();
                } else {
                    if ($tableBody.find('tr').length > 1) {
        $row.remove();
    $tableBody.find('button.delete-row').eq(0).addClass('delete-row');
                    } else {
        $tableBody.find('button.delete-row').eq(0).removeClass('delete-row');
                    }
                }
            });


    $('#incluir_item').on('click', function () {
                var $tableBody = $('tbody');
    var $lastRow = $tableBody.find('tr:last');
    var $newRow = $lastRow.clone();
    $newRow.find('input').val('');
    $newRow.find('td').eq(0).html('<input type="text" class="form-control" name="Serviço[]" size="23">');
    $newRow.find('td').eq(1).html('<input type="text" class="form-control" name="cor[]" size="5">');
    $newRow.find('td').eq(2).html('<input type="text" class="form-control" name="altura[]" size="5">');
    $newRow.find('td').eq(3).html('<input type="text" class="form-control" name="largura[]" size="5">');
    $newRow.find('td').eq(4).html('<input type="text" class="form-control" name="area[]" size="5" readonly>');
    $newRow.find('td').eq(5).html('<input type="text" class="form-control" name="total[]" size="10" readonly>');
    $newRow.find('td').eq(6).html('<input type="date" class="form-control" name="entregue[]" size="5">');
    $newRow.find('td').eq(7).html('<button type="button" class="btn btn-danger btn-sm delete-row">Excluir</button>');
    $tableBody.append($newRow);

            });
        });

function funcaocredito() {
    var inputTotal = document.getElementById('total_pedido');
    var total = parseFloat(inputTotal.value);
    console.log(total);
    var confirmacao = confirm('Credito adiciona 5% ao valor, Posso confirmar?');
        if (confirmacao) {
            if (document.getElementById('total_pedido').value == "") {
                alert("favor calcular o total do pedido primeiro");
                document.getElementById('credito').value = "";
                document.getElementById('credito').blur;
            } else {
                var total = total + parseFloat(inputTotal.value) * 0.05;
                var outros = parseFloat(document.getElementById('debito').value) + parseFloat(document.getElementById('pix').value) + parseFloat(document.getElementById('dinheiro').value)
                console.log(outros);
                var valorFormatado = total.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
                document.getElementById('credito').value = valorFormatado;
            }
        }
        else {
            document.getElementById('credito').value = "";
            document.getElementById('credito').blur;
        }
}

    function funcaodebito() {
        var inputTotal = document.getElementById('total_pedido');
        var total = parseFloat(inputTotal.value);
        var confirmacao = confirm('Credito adiciona 2% ao valor, Posso confirmar?');
        if (confirmacao) {
            if (document.getElementById('total_pedido').value == "") {
                alert("favor calcular o total do pedido primeiro");
                document.getElementById('debito').value = "";
                document.getElementById('debito').blur;
            } else {
                var total = total + parseFloat(inputTotal.value) * 0.02;
                var valorFormatado = total.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
                document.getElementById('debito').value = valorFormatado;
            }
        }
        else {
            document.getElementById('debito').value = "";
            document.getElementById('debito').blur;
        }
    }