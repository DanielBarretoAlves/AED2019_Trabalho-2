# Execeptions

Here's an Example of an Exeception working

	try
	
							{
	
									int numero = Convert.ToInt32(txtValor.Text);
	
		
	
									if ((numero % 2) > 0)
	
									{
	
											throw new Exception("O número ímpar é inválido!");   
	
									}
	
							}
	
							catch (Exception ex)
	
							{
	
									lblMensagem.Text = ex.Message;
	
							}
