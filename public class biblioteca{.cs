//clase prinsipal
public class biblioteca{

    public static void Main(string[] args){
        //define una sintacsis de biblioteca como la metamorfosis y lo inicializa como nuebo
    libro lametamorfosis=new libro();
    //configura el autor
    lametamorfosis.setautor("Franz kafka");
    //configura el numero de pagunas
    lametamorfosis.setnumerodepaginas(128);
    //configura el ISBN
    lametamorfosis.setISBN(978844);
    //lee unos valores, los combierte y los muestra en pantalla
    lametamorfosis.tostring();
    //lee unos valores, los combierte y los muestra en pantalla 
   
    //define una sintacsis de biblioteca como elcoronel no tiene quien le escriba y lo inicializa como nuebo
    libro elcoronelnotienequienleescriba=new libro();
    //configura el autor
    elcoronelnotienequienleescriba.setautor("Gabriel Garcia Marques ");
    //configura el numero de paginas
    elcoronelnotienequienleescriba.setnumerodepaginas(92);
    //configura el ISBN
    elcoronelnotienequienleescriba.setISBN(97898);
    elcoronelnotienequienleescriba.tostring(); 
    
    if(lametamorfosis.consultarnumerodepaginas()>elcoronelnotienequienleescriba.consultarnumerodepaginas()){
        Console.WriteLine("el primer libro tiene mas paginas");
    }else{
        Console.WriteLine("el segundo libro tiene menos paginas ");

    }

}
}