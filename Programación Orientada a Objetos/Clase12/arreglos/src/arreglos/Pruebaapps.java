package arreglos;

public class Pruebaapps {
	
	public static void main(String[] args) {

		int array[][]= new int [3][5];
		
		array[0][1]=5;
		
		int array2[][]= {{1,2,3,4,5}, {6,7,8,9,10}, {11,12,13,14,15}};
		
		for(int i=0;i<array2.length;i++) {
			for(int j=0;j<array2[0].length;j++) {
				System.out.println(array2[i][j]);
			}
		}
		
		for(int i=0;i<array2.length;i++) {
			System.out.println(array2[i][0]);
		}
		
		for(int i=0;i<array2.length;i++) {
			System.out.println(array2[1][i]);
		}
		
	}

}
