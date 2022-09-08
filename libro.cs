public class libro{
    //atiburos de la clase libro
    string titulo="", autor="";
    int ISBN ,numerodepaginas;
    //consultas
    public string consultartitulo(){

        return(this.titulo);
    }
    public string consultarautor(){
        return(this.autor);
    }
    public int consultarISBN(){
        return(this.ISBN);
    }
        public int consultarnumerodepaginas(){
        return(this.numerodepaginas);
    }
    //metodos de accesos
    public void setautor(string nombre){
        this.autor=nombre;
       
    }
    public void settitulo(string libro){
        this.titulo=titulo;
    }
   
    public void setISBN(int ISBN){
        this.ISBN=ISBN;
    }
    public void setnumerodepaginas(int paginas){
        this.numerodepaginas=paginas;
    }
    public void tostring(){
        Console.WriteLine("El libro "+this.titulo+" del autor "+this.autor+" tiene "+numerodepaginas+" paginas");
    }
    }