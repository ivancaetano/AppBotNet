var chat = angular.module('Chat', []);
chat.controller('ChatController', function ($scope, $http) {
    $scope.txNIS = "12135985173";
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
                   console.log(response);
               });
        }
    };
});

