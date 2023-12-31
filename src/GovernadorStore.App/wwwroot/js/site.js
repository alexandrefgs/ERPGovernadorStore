﻿function AjaxModal() {

    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {
                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({
                                keyboard: true
                            },
                                'show');
                            bindForm(this);
                        });
                    return false;
                });
        });
    });
}

function bindForm(dialog) {
    $('form', dialog).submit(function () {
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function (result) {
                if (result.success) {
                    $('#myModal').modal('hide');
                    $('#EnderecoTarget').load(result.url);                         
                } else {
                    $('#myModalContent').html(result);
                    bindForm(dialog);
                }
            }
        });
        return false;
    });
}

function BuscaCep() {
    $(document).ready(function () {

        function limpa_formulário_cep() {
            $("#Endereco_Logradouro").val("");
            $("#Endereco_Numero").val("");
            $("#Endereco_Bairro").val("");
            $("#Endereco_Cidade").val("");
            $("#Endereco_Estado").val("");
        }

        $("#Endereco_Cep").blur(function () {

            var cep = $(this).val().replace(/\D/g, '');

            if (cep != "") {

                var validacep = /^[0-9]{8}$/;

                if (validacep.test(cep)) {

                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Numero").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");

                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?",
                        function (dados) {

                            if (!("erro" in dados)) {
                                $("#Endereco_Logradouro").val(dados.logradouro);
                                $("#Endereco_Numero").val(dados.numero);
                                $("#Endereco_Bairro").val(dados.bairro);
                                $("#Endereco_Cidade").val(dados.localidade);
                                $("#Endereco_Estado").val(dados.uf);
                            }    
                            else {
                                limpa_formulário_cep();
                                alert("Whooops! CEP não encontrado.");
                            }
                        });
                }    
                else {
                    limpa_formulário_cep();
                    alert("Formato de CEP inválido.");
                }
            }    
            else {
                limpa_formulário_cep();
            }
        });
    });
}

window.onload = function () {
    var mensagem = document.getElementById('msg_box');

    setTimeout(function () {
        var opacity = 1;
        var interval = setInterval(function () {
            opacity -= 0.05;                            
            mensagem.style.opacity = opacity;
            if (opacity <= 0) {
                mensagem.style.display = 'none';
                clearInterval(interval);
            }
        }, 100);                      
    }, 2000);                                     
};