# Desafio AuthSoft — Empréstimo de Livros

##  Como Rodar o Projeto

1. Certifique-se de ter o **.NET Framework 4.8** instalado na sua máquina (geralmente já vem nativo em versões recentes do Windows).
2. Abra a pasta do projeto e localize o executável em: `bin/Debug/BibliotecaDesafioAuthSoft.exe` (ou abra a solução no Visual Studio e pressione o botão "Iniciar").

## Decisões técnicas

**Arquitetura em Camadas:** O projeto foi separado em Camada de Apresentação (Forms), Regra de Negócio (Services) e Acesso a Dados (Repositories) para garantir manutenibilidade.
- **Validação de Data de Empréstimo:** Um livro não pode ser emprestado em uma data posterior ao dia atual (decisão tomada para evitar empréstimos planejados que retiram livros disponíveis do acervo).
- **Mostrar apenas livros disponíveis:** A lista de livros exibida para empréstimo filtra apenas os livros que estão disponíveis, evitando confusão para o usuário.
- **Impossível salvar número de livros menor que o número de livros emprestados:** Esta regra garante que o número de exemplares disponíveis não seja inferior ao número de exemplares emprestados ao editar um livro.
- **Validação de Datas de Empréstimo:** A data de devolução não pode ser maior que a data atual e nem menor que a data do empréstimo, garantindo a ordem de empréstimo e devolução, além de não permitir registros de devoluções planejadas que pode causar inconsistência no número de livros emprestados.
- **Busca Case-Insensitive para Leitores:** O nome do leitor é validado ignorando diferenças entre letras maiúsculas e minúsculas (ex: "Maria" e "maria" são tratados como o mesmo leitor), evitando emprestar um mesmo livro para o mesmo leitor duas vezes por erro de digitação.