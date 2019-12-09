Agendar Eventos
usuário :  visinho, representante
Relatorio: Log , Feed


1 - entra, informa algo de util baseado nas categorias, vai oedir o acesso ao representante, e vai jogar ao Feed da categoria selecionada.  
2 - Procurar Eventos


	public void criarSenha(string senha)
			{
				StreamWriter addPass;
				string path = "senha"+_nome+".txt";
				addPass = File.CreateText(path);
				addPass.WriteLine(senha);
				addPass.Close();


			}

			//TODO: Validar Senha

			public bool validarSenha(string senha)
			{
				
			string linha;
				using (StreamReader reader = new StreamReader("senha"+_nome+".txt"))
				{
					linha = reader.ReadLine();
				}
				Console.WriteLine(linha);
				if(linha == senha)
				{
					return true;
				}else{
					Console.WriteLine("Senha Invalida");
					return false;
				}
			}

