# language: pt-BR
@cadastrar_horario_medicamento
Funcionalidade: Cadastrar horario do medicamento
  Cadastrar o(s) horario(s) do(s) medicamento(s) com isso podemos identificar quais sao os medicamentos mais consumidos, qual e o publico alvo, se teve ou nao reacao alergica.

  @Usuario_cadastra_o_horario_do_medicamento
  Esquema do Cenario: Usuario cadastra o horario do medicamento
    Dado Que o Usuario autentica com <usuario> e <senha> no AVISA como <tipo acesso>
    Quando O Usuario precisa tomar o <medicamento>
    Então O <horario> do medicamento fica registrado
    E O envia a notificacao para o <cuidador>
    Exemplos:
    # Precisam ficar entre "aspas" para dar match na regex
      | usuario   | senha      | tipo acesso              | medicamento  | horario | cuidador   |
      | "usuario" | "teste"    | "Usuario nao autorizado" | "Anador"     | "08:00" | "Fabio"    |
      | "usuario" | "senha"    | "Usuario autenticado"    | "Novalgina"  | "12:00" | "Leandro"  |
      | "usuario" | "test"     | "Usuario nao autorizado" | "Dipirona"   | "15:00" | "Deryk"    |
      | "usuario" | "password" | "Usuario nao autorizado" | "Mucosolvan" | "21:00" | "Fabio"    |
      | "usuario" | "senha"    | "Usuario autenticado"    | "Aspirina"   | "11:55" | "Deryk"    |