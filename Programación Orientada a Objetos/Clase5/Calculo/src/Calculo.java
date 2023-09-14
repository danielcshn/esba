import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Calculo {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String s;
		int lineas=1;
		
		try	{
			System.out.print("Que archivo desea analizar?");
			
			BufferedReader stdin=new BufferedReader(new InputStreamReader(System.in));
			String archivo = stdin.readLine();
			
			BufferedReader sarchivo= new BufferedReader(new FileReader(archivo));
			while(( s=sarchivo.readLine())!=null)
				lineas++;
			System.out.println("El archivo " + archivo + " contiene " + lineas + " renglones de codigo.");
			sarchivo.close();
			
		} catch(IOException exc) {
			System.err.print(exc);
			System.out.println("asegurese de haber proporcionado" + "la extensiuon del archivo (\\\".java\\\")");
		} finally {
			System.out.println("");
			System.out.println("Esta es la mejor manera de aprender Streams, practicando!");
		}
		
	}

}
