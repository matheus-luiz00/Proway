jQuery(document).ready(function(){
    /* Indica que o evento submit do form irá realizar esta ação agora*/
    
    
    jQuery('#bntSalvar').click(function(){
         Editing();
         
        $('#bntSubmit').show();
        $('#bntSalvar').hide();
        $('#bntCancelar').hide();
        
        $('#Id').val("");
        $('#Nome').val("");
        $('#Descricao').val("");
    });
    
    jQuery('#bntCancelar').click(function(){
        $('#bntSubmit').show();
        $('#bntSalvar').hide();
        $('#bntCancelar').hide();
        
        $('#Id').val("");
        $('#Nome').val("");
        $('#Descricao').val("");
    });
    
    GetMethod();
});

function GetByID(id){
    $('#bntSubmit').hide();
    $('#bntSalvar').show();
    $('#bntCancelar').show();
    
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:59271/Api/Autores/"+id,
        "method": "GET",
            "headers": {
                "Content-Type": "application/json",
                "Accept": "*/*"
            }
        }

        $.ajax(settings).done(function (response) {
            $('#Id').val(response.Id);
            $('#Nome').val(response.Nome);
            $('#Descricao').val(response.Descricao);
        });
    
}

function Editing(){
    var dados = $('#formusuarios').serialize();
    var id = $('#Id').val();

     var settings = {
      "crossDomain": true,
      "url": "http://localhost:59271/Api/Autores/"+id,
      "method": "PUT",
      "headers": {
        "Content-Type": "application/x-www-form-urlencoded",
        "Accept": "*/*"
      },
      "data": dados
    }

    $.ajax(settings).done(function (response) {
        GetMethod();
    });
}

function Deleting(id){
         var settings = {
          "crossDomain": true,
          "url": "http://localhost:59271/Api/Autores/"+id,
          "method": "DELETE",
          "headers": {
            "Content-Type": "application/x-www-form-urlencoded",
            "Accept": "*/*"
          }
        }

        $.ajax(settings).done(function (response) {
            GetMethod();
        });
}
    
function GetMethod(){
        var settings = {
            "async": true,
            "crossDomain": true,
            "url": "http://localhost:59271/Api/Autores",
            "method": "GET",
            "headers": {
                "Content-Type": "application/json",
                "Accept": "*/*"
              }
            }

            $.ajax(settings).done(function (response) {
              RefreshGrid(response);
            });
        
        return false;
}

function RefreshGrid(contentValue){
   $('#tDataGrid').empty();
   $('#tDataGrid').html(  '<tbody>'
                        + 	'<tr>'
                        + 		'<th>ID</th>'
                        + 		'<th>Nome</th>'
                        + 		'<th>Descrição</th>'
                        + 		'<th>Ativo</th>'
                        + 		'<th>Opções</th>'
                        + 	'</tr>'
                        + '</tbody>');

    $.each(contentValue,function(index,value) {
    var row =     '<tr>'
                    + '<td>' + value.Id       + '</td>'
                    + '<td>' + value.Nome    + '</td>'
                    + '<td>' + value.Descricao    + '</td>'
                    + '<td>' + value.Ativo    + '</td>'
                    + '<td>' 
                    + 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
                    + 		'<div    class=\'col-md-6\'>'
                    + 			'<button class=\'btn btn-block btn-danger btn-delet-event col-md-3\' type=\'button\'  send-post=\'Autores\' value=\'' + value.Id +'\'>Remover</button>'
                    + 		'</div>'
                    + 		'<div     class=\'col-md-6\'>'
                    + 			'<button  class=\'btn btn-block btn-success btn-editing-event col-md-3\'    type=\'button\' send-post=\'Autores\' value=\'' + value.Id +'\'>Editar</button>'
                    + 		'</div>'
                    + 	'</div>'
                    + '</td>'
                + '</tr>';
    $('#tDataGrid').append(row);
    });
    SetGridClickEvents();
}