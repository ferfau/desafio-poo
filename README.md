<h1 align = "center">Desafio de POO: A Saga dos Smartphones! 📱✨</h1>


- - -

<p style="text-align: justify;">E aí, galera! Saca só essa parada que a gente fez: um projeto que nasceu de um desafio super legal! A missão era criar um sistema que lidasse com celulares de um jeito esperto, sabe? A ideia era tipo "pensar no que todo celular tem em comum" (a famosa abstração), e depois deixar que marcas diferentes (tipo aquele iPhone ostentação ou o Nokia que não quebrava nunca) tivessem seus próprios truques e jeitos de funcionar. Tudo isso usando a Orientação a Objetos (POO) pra gente ter um código que pudesse ser reaproveitado à beça!

Qual Era a Missão (ou o Rolê do Desafio)?
O coração do desafio era simular celulares, mas com uns pontos chave pra deixar a coisa interessante:

Celular Genérico: A gente precisava sacar quais características e ações são universais pra qualquer smartphone. Isso virou a nossa classe-base.
Cada Marca com Seu Estilo: Pensa bem, um iPhone e um Nokia fazem as mesmas coisas (ligar, mandar mensagem), mas cada um tem seu "jeitinho", né? A gente precisava que o código refletisse essas diferenças, tipo na hora de instalar um app.
Zero Repetição, Por Favor!: Ninguém aguenta copiar e colar código. A POO veio pra salvar a pátria, permitindo que a gente escrevesse uma vez e usasse pra um monte de tipo de celular diferente, evitando retrabalho e uns bugs chatos.
POO na Veia!: Era a chance de botar pra quebrar e usar conceitos como Herança (quando um "filho" pega as coisas do "pai"), Polimorfismo (a mesma coisa, mas com jeitos diferentes de acontecer) e Classes Abstratas (receitas que precisam ser completadas).</p>

- - -

<p style="text-align: justify;">Como a Gente Resolveu Essa Parada?
A gente meteu a mão na massa com uma tática clássica da POO:

1. A Classe Smartphone 📱 (A "Mãe" de Todos os Celulares!)
Criamos uma tal de classe abstrata que batizamos de Smartphone. Imagina ela como o "esqueleto" ou a "receita" geral de qualquer celular. Ela diz o que todo celular tem e o que ele faz:

Coisas que Todo Celular possui: Aqueles dados básicos, tipo o Numero do telefone , o Modelo, o tal do IMEI (um RG do celular) e a Memoria.

Ações Padrão: As funções que todo celular sabe fazer: Ligar() pra um amigo e ReceberLigacao() quando alguém te liga.

Ações "Personalizáveis" (A Hora do Show!)✨: E aqui que o bicho pega! O método InstalarAplicativo() foi declarado como abstrato. Isso significa que a classe Smartphone fala "Olha, todo celular instala app", mas não diz como. Ela deixa essa parte pros filhos resolverem do jeito deles. Genial, né?

2. Classes Iphone 🍎 e Nokia 🐍 (Os Filhos Com Estilo Próprio!)
Depois, vieram as classes Iphone e Nokia. Elas herdam tudo de bom da Smartphone. Isso já garantiu que a gente não precisasse repetir código pra todas aquelas características e ações básicas.

A sacada é que cada uma dessas classes implementa o método InstalarAplicativo() do seu próprio jeitinho. Isso é o que chamamos de Polimorfismo: você chama a mesma função (InstalarAplicativo()), mas ela se comporta de um jeito diferente dependendo se é um iPhone ou um Nokia. É tipo pedir uma pizza , mas cada pizzaria faz do seu jeito!

3. O Resultado: Código Reutilizável e Flexível DEMAIS!💪
Com essa organização, a gente conseguiu:

♻️Reutilizar um monte de coisa (propriedades e métodos básicos) da Smartphone pros nossos Iphone e Nokia.
Personalizar a ação de InstalarAplicativo() pra cada marca.
Manter o código arrumadinho, fácil de entender e seguindo os princípios da POO. Um luxo!</p>
- - -
<p style="text-align: justify;">Quer Ver Essa Mágica Acontecer?
Pra dar uma espiada em como tudo isso funciona na prática:

Primeiro, confere se você tem o SDK do .NET instalado na sua máquina (é tipo o kit de ferramentas pra rodar códigos C#).
Abre o terminal na pasta do projeto e digita dotnet build. Isso vai "preparar" o código.
Depois, é só mandar um dotnet run pra ver a coisa toda funcionando!
Você vai ver no console como a gente cria um iPhone e um Nokia e como eles fazem as paradas de ligar e instalar aplicativos, mostrando a diferença de comportamento do método InstalarAplicativo pra cada um. É simples, mas mostra o poder da POO!</p>



![Static Badge](https://img.shields.io/badge/Status--black?label=Em%20Desenvolvimento&color=green)
