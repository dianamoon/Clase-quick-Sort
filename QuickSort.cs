
namespace QuickSort
{
    class QuickSort
    {

        //declaramos un arreglo de enteros

        private jugador[] vector;

        public QuickSort(){}
        public void ordenarVector(jugador[] vector, int primero, int ultimo)
        {
                int i,j, central;
                int pivote;
                int chubuntu;
                central =(primero +ultimo)/2;//identificamos el elemento central del arreglo
                pivote = vector[central].NumeroJugador;
                i = primero;
                j = ultimo;
                do
                {
                    while (vector[i].NumeroJugador < pivote) i++;

                    while (vector[j].NumeroJugador > pivote) j--;
                    if (i <= j)
                    {
                        jugador temp;
                        temp =vector[i];
                        vector[i]=vector[j];
                        vector[j]=temp;
                        i++;
                        j--;
                    } 

                } while (i <= j);

                if (primero < j) ordenarVector(vector, primero, j);

                if (i < ultimo) ordenarVector(vector, i, ultimo);
               
                this.vector = vector;

               
        }

        public jugador[] devolverVector()
        {
            return vector;
        }
    }
}
