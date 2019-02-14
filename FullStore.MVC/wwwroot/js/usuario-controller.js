$(document).ready(function () {
    $('.btn-incluir').click(function () {
        abrirModalLoading("modal_cadastro_usuario");
        $('.modal_cadastro_usuario').on('shown.bs.modal', function () {
            bootbox.hideAll();
            abrirModalCadUsuario();
            $('.cadUsuario').on('shown.bs.modal', () => {
                $('#dataNascimento').datepicker({
                    language: 'pt-BR'
                });
            });
        });

    });
});

var abrirModalLoading = classe => {
    if (classe != null || classe != undefined) {
        bootbox.dialog({
            className: `${classe}`,
            message: `<div class="text-center">
                        <i class="fa fa-spin fa-spinner"></i> Loading...
                      </div>`
        });
    }
};

var abrirModalCadUsuario = () => {
    bootbox.dialog({
        title: 'Cadastro de Usuários',
        className: 'cadUsuario',
        onEscape: function () { },
        message: `<form>
                      <div class="form-group">
                         <label for="nome">Nome </label>
                          <input type="text" class="form-control" id="nome" placeholder="Digite o Nome">
                      </div>
                      <div class="form-group">
                          <label for="sobrenome">SobreNome </label>
                          <input type="text" class="form-control" id="sobrenome" placeholder="Digite o Sobrenome">
                      </div>
                      <div class="form-group">
                          <label for="cpf">CPF </label>
                          <input type="text" class="form-control" id="cpf" placeholder="Digite o CPF">
                      </div>
                      <div class="form-group">
                          <label for="telefone">Telefone </label>
                          <input type="text" class="form-control" id="telefone" placeholder="Digite o Telefone">
                      </div>
                      <div class="form-group">
                          <div class='input-group date' id='dataNascimento'>
                              <input type='text' class="form-control" />
                              <span class="input-group-addon">
                                  <span class="glyphicon glyphicon-calendar"></span>
                              </span>
                          </div>
                      </div>
                  </form>`,
        buttons: {
            confirm: {
                label: 'Salvar',
                className: 'btn-primary',
                callback: () => {
                    return false;
                }
            },
            cancel: {
                label: 'Sair',
                className: 'btn-danger',
                callback: () => {
                    return true;
                }
            }
        }
    });
};