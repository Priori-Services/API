# Changelog

## [1.4.0](https://github.com/Priori-Services/API/compare/v1.3.0...v1.4.0) (2023-06-10)


### Features

* endpoint p/ alteração de senha e saldo do cliente ([ff4122e](https://github.com/Priori-Services/API/commit/ff4122e8b8d8b2ced19ad92d340897e70254d107))
* endpoint p/ checkar se cliente é consultor / authorizations no posts ([c431e81](https://github.com/Priori-Services/API/commit/c431e812b607d751ff0c705cbfd7791d6377c058))
* endpoint p/ password reset request ([0a3a1f3](https://github.com/Priori-Services/API/commit/0a3a1f359733913044a6b13aeec95746967cd9e7))
* endpoint p/ pegar histórico de investimento ([a3c61f8](https://github.com/Priori-Services/API/commit/a3c61f81d4cfbb751195fde60022a62becec6b3e))
* inserção da requisição de pontuação do cliente ([91afb79](https://github.com/Priori-Services/API/commit/91afb79f97213f988fb7e10720a2a8ecbe5d03e3))


### Bug Fixes

* adicionar descrição do post quando criado ([07d9697](https://github.com/Priori-Services/API/commit/07d96975b9f00ebec02441bdaf6998ddecc9a8b0))
* adicionar devbox lock p/ nn atualziar sempre que usar devbox ([5b2a5f9](https://github.com/Priori-Services/API/commit/5b2a5f94bff5a4a9c82d18f43891b938b56eaa6f))
* adicionar perms p/ clientes autenticarem no alterarcliente ([7f505fe](https://github.com/Priori-Services/API/commit/7f505fe1999cad7c4346daaf0e0edfe95274063b))
* bad request se carteira do usuário não existir nas operações de saldo ([c8ac4d4](https://github.com/Priori-Services/API/commit/c8ac4d449e7da84448833bc711eb9ba6454589ff))
* carteira não compilando por erros de variaveis ([d93f6b0](https://github.com/Priori-Services/API/commit/d93f6b0150b4c35250ad298bd9b10e3386d49fc2))
* carteirainvestimento sem id_efetuação e data_efetuacao ([ef77ddd](https://github.com/Priori-Services/API/commit/ef77ddd99daa2be66f4c313e2eed3301da759532))
* handeling pra remover categoria caso nn exista mais posts nela ([787b80f](https://github.com/Priori-Services/API/commit/787b80f25fe453793395ad77e2963e8b431f3e39))
* inserção de saldo [@tuliliorockes](https://github.com/tuliliorockes) ([482b6d9](https://github.com/Priori-Services/API/commit/482b6d903731447be31864aa6a2ac1b3372882ff))
* json object p/ password reset request ([328f921](https://github.com/Priori-Services/API/commit/328f9214aa55a863570d5894a44bad16ac74f8c4))
* remover authorize desnecessários nos gets de atualizações ([252ffd3](https://github.com/Priori-Services/API/commit/252ffd362221d853df55c1b15936bfc39ada5a79))
* remover endpoints desnecessários ([d358e4e](https://github.com/Priori-Services/API/commit/d358e4e50d30333e85db2e78ccd1cda99954b494))
* set nullable data_encerramento na carteiraDBO ([861c66f](https://github.com/Priori-Services/API/commit/861c66f661ce0caaa6753c8bad69cdbcf383292d))
* typo ([7fda620](https://github.com/Priori-Services/API/commit/7fda620521a89bdbae490f55fac81316c2e389ed))
* utilizar somente campos que usuário vai usar no carteira investimento ([81bf4df](https://github.com/Priori-Services/API/commit/81bf4df302b1721309908aa0488d274acb84e1ea))

## [1.3.0](https://github.com/Priori-Services/API/compare/v1.2.0...v1.3.0) (2023-05-30)


### Features

* adicionar endpoint p/ todas as carteiras de investimento de X usuário ([6765d9b](https://github.com/Priori-Services/API/commit/6765d9be8ed5f9c8c2602ab808a89099feda2952))
* building e publishing de container no gh-actions ([f535968](https://github.com/Priori-Services/API/commit/f5359685d3aa81f1cd6a632542064175ff9d2500))
* criar carteira junto com o usuário com cadastro ([babb03a](https://github.com/Priori-Services/API/commit/babb03a5b263920a0bf3aa77ae215e002b5b4163))
* criar endpoint de saldo de usuário na CarteiraInvestimento ([897b8fe](https://github.com/Priori-Services/API/commit/897b8fe19f23781aa6fd92aa4f012272ad9281f7))
* endpoint p/ informações do cliente ([355a533](https://github.com/Priori-Services/API/commit/355a533bcc59c1ae9da9b47f5d9cd762c4abb477))


### Bug Fixes

* ajeitar endpoint de informações de cliente ([a18496a](https://github.com/Priori-Services/API/commit/a18496a397765aeb317dfdc53cf9478ae56b19ce))
* ajeitar numeração da situação assessoria do cliente ([cfe85a3](https://github.com/Priori-Services/API/commit/cfe85a31c92b3f32841656a66886e26b5dce865e))
* colocar o branch correto no GH actions ([e89a074](https://github.com/Priori-Services/API/commit/e89a074edb17f6d6588506c9ac7ef9a81493b458))
* endpoint de info de cliente não requisitando as informaçẽos corretas ([efec152](https://github.com/Priori-Services/API/commit/efec152e7f262c54b2e5f1d5272c73c1c208d66a))
* modificar modelos para nova versão do banco de dados ([e5709d7](https://github.com/Priori-Services/API/commit/e5709d78f421fe38496e3d11b777aaeefa615c25))
* numeração da Reposta Assessoria ([2824e45](https://github.com/Priori-Services/API/commit/2824e455b58d7384cfdf7ea8c9da8e16585132b8))
* problemas de nullificação na interface de repositório ([80b1bdc](https://github.com/Priori-Services/API/commit/80b1bdc47e52e4f6849b415599884114110fb61a))
* returns corretos do clientecontroller ([ad958ea](https://github.com/Priori-Services/API/commit/ad958ead2f7b0fd8b6e138fd1a2368d3ff983f54))
* roles não especificado em atualizacaocontroller ([e53be40](https://github.com/Priori-Services/API/commit/e53be40358d9e9ab15174e9585d12b7869c83a51))

## [1.2.0](https://github.com/Priori-Services/API/compare/v1.1.0...v1.2.0) (2023-05-12)


### Features

* adicionar handeling para todos os erros de BD ([685c60c](https://github.com/Priori-Services/API/commit/685c60c1bd78ce2511352d93a8c64999c899a3c7))
* configuração da API dedicada em classe ([2283fec](https://github.com/Priori-Services/API/commit/2283fec8b1b503aff45a9d24696c13f8d3c758c3))
* container mais leve utilizando chainguard images e fix ports no README ([7ac28e5](https://github.com/Priori-Services/API/commit/7ac28e5c4352713398b463d12da880b88e8c8b44))
* retornar ID junto de JWT ao login ([1a156a6](https://github.com/Priori-Services/API/commit/1a156a68aaa2f51e7932823b09597fc8e0827947))
* start.sh p/ setar variaveis de ambiente no linux ([271f8ab](https://github.com/Priori-Services/API/commit/271f8ab436481b7557ef84e422dd1141177dafa4))
* usar senhas em autenticação e cadastro do sistema sem utilizar parâmetros ([15d2fcb](https://github.com/Priori-Services/API/commit/15d2fcb6f8c2d771c0fc5d40d6973b631bc3ed23))
* **WIP:** melhorar tratamento de erros e robustês do código dos Controllers ([bc2180c](https://github.com/Priori-Services/API/commit/bc2180c3c618b7d93c7be1e2f3740f7935f4ddbb))


### Bug Fixes

* arquivos gerados automaticamente ([727007b](https://github.com/Priori-Services/API/commit/727007b723fb196a1ab40b525b0931794696c7f9))
* arquivos gerados automaticamente ([264f215](https://github.com/Priori-Services/API/commit/264f215c290e4bcfa3fdea1a83c9ade93cd00975))
* arquivos gerados automaticamentes ([56c7325](https://github.com/Priori-Services/API/commit/56c7325f59198d44c665d0ac289defa40f840358))
* atualizacao controller não sendo executado ([e5ad65e](https://github.com/Priori-Services/API/commit/e5ad65e4cf742c2eb71a2d7e43eb26e9d5ed9b58))
* checkar corretamente se usuário não existe antes de login ([eec6ddb](https://github.com/Priori-Services/API/commit/eec6ddbfbc979c5d0628df4613c14961af9f5312))
* especificar PRIORI_DATABASE_USER na config ([01316a0](https://github.com/Priori-Services/API/commit/01316a0540a4b9de93597290fead7147ba188787))
* implementar SID corretamente em consultor ([55dfe80](https://github.com/Priori-Services/API/commit/55dfe800302a1a6076dd7073ec8715a1d31c1f6b))
* melhorar segurança com post request no ClienteController ([b5bb507](https://github.com/Priori-Services/API/commit/b5bb507556f74425f3c8a1d35a3713b105ee786b))
* mover namespace PRIORI[...].Models para Model ([c3529e2](https://github.com/Priori-Services/API/commit/c3529e216f69c076722c0dc2035bf8e97f9c9f74))
* permissões corretas para atualizações ([2152c1f](https://github.com/Priori-Services/API/commit/2152c1fc6f3bb64589e099da0b9c74cca14a1e9d))
* permitir funcionalidade dos endpoints da Cateira Investimentos ([2dbdbc7](https://github.com/Priori-Services/API/commit/2dbdbc7e196808ea2beea17b9d07990c44e9406f))
* remove visualstudio project files ([eda1408](https://github.com/Priori-Services/API/commit/eda140818467dba9f7dd437fd51b31233bb91a7f))
* remover campos desnecessários em Model de Carteira ([4787d39](https://github.com/Priori-Services/API/commit/4787d39ff01bd06d938edd245b1cee76134fefd3))
* silenciar erros de nulificação do DbContext ([07c3c41](https://github.com/Priori-Services/API/commit/07c3c4113611946e1fe1520954949dfe0ede59d6))
* simplificação do container da API ([cf3ad6a](https://github.com/Priori-Services/API/commit/cf3ad6a46e2cd984c9e887b013191e86a41c4c03))
* typo em declaração da tabela Clientes ([5a4f165](https://github.com/Priori-Services/API/commit/5a4f1653b7a76b2d2d2dd5d0e02b224c73fb34e6))
* typo nas variáveis do programa ([b0eca86](https://github.com/Priori-Services/API/commit/b0eca86d28e52bfc152a3b72f32e57cd190819f2))
* variavel PRIORIUSER não sendo corretamente transferida p execução ([104deb3](https://github.com/Priori-Services/API/commit/104deb35edaea11d49b302bbb1685f55fabc8c7c))
* **wip,minor:** remove some requirements for registering an user ([82838d6](https://github.com/Priori-Services/API/commit/82838d6e480a89bbd745982393b310c8d4d5f40d))


### Reverts

* remover senha do DBO ([13c79ea](https://github.com/Priori-Services/API/commit/13c79ea87bd3faabf49bb85afc18be381c66807b))
* senha especificada por meio de argumento em vez de DBO ([d1f6a75](https://github.com/Priori-Services/API/commit/d1f6a75363e5f5c4b2b243c536c369ce556ff1a9))

## [1.1.0](https://github.com/Priori-Services/API/compare/v1.0.0...v1.1.0) (2023-04-15)


### Features

* Data Annotations ([#13](https://github.com/Priori-Services/API/issues/13)) ([20e9e70](https://github.com/Priori-Services/API/commit/20e9e7073d442249e3eaf28bcb4379ff472ce60e))
* README descritivo mostrando como utilizar o projeto corretamente ([c413f9b](https://github.com/Priori-Services/API/commit/c413f9bf5fa149d0dfc84932759755e7b1c345e0))


### Bug Fixes

* implementar connection string e JWT key  corretamente ([bd3d88d](https://github.com/Priori-Services/API/commit/bd3d88dc1503acbd4f30408df5bc707b99a66b0c))
* mover start p/ example para que não possam ocorrer pushes incorretos ([94940e3](https://github.com/Priori-Services/API/commit/94940e38521bc5ddee70a7263d88246b072b6d13))
* resolvendo comflito model CarteiraInvestimento ([#11](https://github.com/Priori-Services/API/issues/11)) ([a539ee5](https://github.com/Priori-Services/API/commit/a539ee519f0e47d3326571d2b37aed84dbe24e2f))

## 1.0.0 (2023-04-15)


### Features

* add actions for standardizing development ([b053ec4](https://github.com/Priori-Services/API/commit/b053ec48aadba22767652f4ddcf76ddb49f88cd9))
* appsettings exemplar ([edd2bc0](https://github.com/Priori-Services/API/commit/edd2bc00c2e0ffc53fc8cf030d5a3dcb127187f0))
* devcontainer p/ standard dev env ([364c35b](https://github.com/Priori-Services/API/commit/364c35b5e893ee3ce37642a08513106d62b6540c))
* env variables for database configuration ([8a58a07](https://github.com/Priori-Services/API/commit/8a58a07b706b8a4273ad7c62f83afda27c7ac7ed))
* More descriptive endpoints for blog posts ([65bca83](https://github.com/Priori-Services/API/commit/65bca83bb309df8b3c3217840b305e4c2fe031c8))
* remover senha não-criptografada ([7c10f75](https://github.com/Priori-Services/API/commit/7c10f754767229e04ae64d2b630c656a362bac58))


### Bug Fixes

* better readability and separation of namespace scoping ([16a6688](https://github.com/Priori-Services/API/commit/16a6688ce59912f7cfb0ee818486aaab8d5dede5))
* conventional commits on develop ([1309026](https://github.com/Priori-Services/API/commit/130902647dd9546bf711438764722654d9cd0580))
* remove visual studio cache files ([247ed5e](https://github.com/Priori-Services/API/commit/247ed5ee7a6d445e9710a3a9b09d1cc62115484e))
* remover referência desnecessária ([e4cf3b1](https://github.com/Priori-Services/API/commit/e4cf3b18b3583d354ab9db7ee5551d7f35983fff))
* run release actiono on develop ([9fecde3](https://github.com/Priori-Services/API/commit/9fecde3998a2471cc2864d384dccdbdb4fdbfd9c))
* typo em data encerramento ([7a6f244](https://github.com/Priori-Services/API/commit/7a6f244f5bdd653cc57c3e744b695043ea50351b))
* typo em metodo CreateInvestimento ([0cae178](https://github.com/Priori-Services/API/commit/0cae17803ef7e38e9c2618c26f5674c4903375c9))
* typo em tipo investimento ([578e18e](https://github.com/Priori-Services/API/commit/578e18e0bf1493a42bb0e1ded44ec4770bc6c034))
