namespace PilaLibros
{
    class FabricaLibro
    {
        public Libro crearLibro(string tipo, string nombre, string editorial, string tema, string titulo, string autor, Genero genero,  int nropaginas)
        {
            switch (tipo)
            {
                case "Enciclopedia":
                    return new Enciclopedia(nombre, editorial, tema);
                    break;
                case "Novela":
                    return new Novela(titulo, autor, genero);
                    break;
                case "Revista":
                    return new Revista(titulo,nropaginas);
                    break;
                default:
                    return null;

            }

        }
    }
}