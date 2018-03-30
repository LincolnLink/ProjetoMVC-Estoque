//função inicial do jquery..
//quando a página estiver pronta, faça..

$(document).ready(function () {

    //imprimir mensagem no log do navegador..
    console.log('JQuery iniciado!');

    //função ajax para consultar os estoques..
    $.ajax({
        type: "POST",
        url: "/Estoque/ConsultarEstoque",
        data: {},
        success: function (lista) {
            console.log("Dados: " + lista);
            var conteudo = "<option value=''>Escolha uma Opção</option>";

            for (var i = 0; i < lista.length; i++) {
                conteudo += "<option value='" + lista[i].IdEstoque + "'>";
                conteudo += lista[i].NomeEstoque;
                conteudo += "</option>";
            }

            $("#estoque").html(conteudo);
        },
        error: function (e) {
            console.log("Erro: " + e.status);
        }
    });

    //Criando um evento no botão de cadastro..
    $("#btncadastro").click(function () {

        //resgatar o conteudo dos campos do formulário..
        //objeto
        var model = {

            //atributos
            Nome: $("#nome").val(),
            Preco: $("#preco").val(),
            Quantidade: $("#quanditdade").val(),
            IdEstoque: $("#estoque").val()

        };

        //imprimir o objetivo
        console.log(model);

        //função AJAX (requisição ao servidor)
        $.ajax({

            type: "POST", //requisição POST
            url: "/Produto/CadastrarProduto", //endereço
            data: model, //dados JSON enviados
            success: function (msg) { //resultado de sucesso
                console.log(msg);

                //exibir a mensagem na label
                $("#mensagem").html(msg);
                //limpar os campos
                $(".form-control").val("");
            },
            error: function (e) { //falha
                console.log("Erro ao cadastrar produto: " + e.status);
            }
        });

    });
});