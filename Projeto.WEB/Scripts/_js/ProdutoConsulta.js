function Consultar() {

    //criando um JSON para enviar os dados
    var model = {

        filtro: $("#nome").val()

    };

    //consultar os produtos
    $.ajax({
        type: "POST",
        url: "/Produto/ConsultarProdutos",
        data: model,
        success: function (lista) {
            var conteudo = "";

            for (var i = 0; i < lista.length; i++) {
                conteudo += "<tr>";
                conteudo += "<td>" + lista[i].IdProduto + "</td>";
                conteudo += "<td>" + lista[i].Nome + "</td>";
                conteudo += "<td>" + lista[i].Preco + "</td>";
                conteudo += "<td>" + lista[i].Quantidade + "</td>";
                conteudo += "<td>" + lista[i].Total + "</td>";
                conteudo += "<td>" + lista[i].DataCadastro + "</td>";
                conteudo += "<td>";
                conteudo += "<a href='/Produto/Edicao' class='btn btn-primary'>Atualizar</a>";
                conteudo += "&nbsp;";
                conteudo += "<a href='/Produto/Exclusao' class='btn btn-danger'>Excluir</a>";
                conteudo += "</td>";
                conteudo += "</tr>";
            }

            //popular a tabela
            $("#tabela tbody").html(conteudo);
            $("#quantidade").html(lista.length);

        },
        error: function (e) {
            console.log("Erro: " + e.status);
        }
    });

}

function Excluir() {

    console.log("Produto Excluido!");
}

$(document).ready(function () {
    Consultar();

    //Cria um evento no campo nome
    $("#nome").keyup(function () {
        Consultar();
    });

    //Excluir o Produto
    $("#btnExcluir").click(function () {
        Excluir();
    });

});       
