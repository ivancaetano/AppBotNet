var chat = angular.module('Chat', []);
chat.controller('ChatController', function ($scope, $http) {
    $scope.txNIS = "12589139081";
    $scope.mensagens = [
    ];
    $scope.dialogos = [
    ];

    
    $scope.msgUsuario = function () {
        if ($scope.txMensagem.length>0) {
            $scope.mensagens.push({ user: true, texto: $scope.txMensagem });
          
            $("#chatBody").animate({ scrollTop: $("#chatBody")[0].scrollHeight }, 100);
            $http.get("/Watson/Conversa?texto=" + $scope.txMensagem)
               .then(function (response) {
                   $scope.mensagens.push({ user: false, texto: response.data.output.text[0] });
                   $scope.dialogos.push(response.data);
               });
        }
        $scope.txMensagem = "";
        $scope.demandasSISGED();
    };
    $scope.demandasSISGED = function () {
        if ($scope.txNIS.length ==11) {
           
            $http.get("/SISGED/ListaDemandas?coNIS=" + $scope.txNIS)
               .then(function (response) {

                   if (response.data.length>0) {
                       var demanda=response.data[0];
                       $scope.mensagens.push({ user: false, texto: 'Identifiquei que a sua última solicitação de serviços se encontra na situação "' + demanda.gedtb006_situacao.no_situacao + '", a justificativa apresentada foi: "' + $(demanda.gedtb002_historico_demanda.slice(-1)[0].tx_apontamento).text() + '"' });
                   }

                   
               });
        }
    };
});

