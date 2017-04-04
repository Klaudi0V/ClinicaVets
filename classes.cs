//*************************************************************
// chave a ser adicionada ao ficheiro Web.config, para 
// referenciar a localização da BD
//*************************************************************
<connectionStrings>
   <!-- MSSQLLocalDB -->
   <add name="DefaultConnection"
        connectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\VetsDB.mdf;Integrated Security=True;"
        providerName="System.Data.SqlClient" />
</connectionStrings>
   
  

//#############################################################
// criação das classes DONOS, VETERINARIOS, ANIMAIS e CONSULTAS
//#############################################################

// DONOS
//=============================================================

// vai representar os dados da tabela dos DONOS

// criar o construtor desta classe
// e carregar a lista de Animais
public Donos() {
   ListaDeAnimais = new HashSet<Animais>();
}


[Key]
public int DonoID { get; set; }

[Required]
public string Nome { set; get; }

[Required]
public string NIF { get; set; }

// especificar que um DONO tem muitos ANIMAIS
public ICollection<Animais> ListaDeAnimais { get; set; }


// ANIMAIS
//=============================================================

public Animais() {
   // inicialização da lista de Consultas de um Animal
   Consultas = new HashSet<Consultas>();
}

[Key]
public int AnimalID { get; set; }

[Required]
[StringLength(30)]
public string Nome { get; set; }

[Required]
[StringLength(30)]
public string Especie { get; set; }

[Required]
[StringLength(30)]
public string Raca { get; set; }

public float Peso { get; set; }

public float? Altura { get; set; }


// **************************
// criar a chave forasteira
// relaciona o objeto ANIMAL com um objeto DONO
public Donos Dono { get; set; }

// cria um atributo para funcionar como FK, na BD
// e relaciona-o com o atributo anterior
[ForeignKey("Dono")]
public int DonosFK { get; set; }
// **************************

// um ANIMAL tem uma coleção de CONSULTAS
public virtual ICollection<Consultas> Consultas { get; set; }




// VETERINARIOS
//=============================================================

public Veterinarios() {
   Consultas = new HashSet<Consultas>();
}

[Key]
public int VeterinarioID { get; set; }

[Required]
[StringLength(30)]
public string Nome { get; set; }

[StringLength(50)]
public string Rua { get; set; }

[StringLength(10)]
public string NumPorta { get; set; }

[StringLength(10)]
public string Andar { get; set; }

[StringLength(30)]
public string CodPostal { get; set; }

[StringLength(9)]
public string NIF { get; set; }

[Column(TypeName = "date")]
public DateTime? DataEntradaClinica { get; set; }

[Required]
[StringLength(30)]
public string NumCedulaProf { get; set; }

[Column(TypeName = "date")]
public DateTime? DataInscOrdem { get; set; }

[StringLength(50)]
public string Faculdade { get; set; }

public virtual ICollection<Consultas> Consultas { get; set; }




// CONSULTAS
//=============================================================

[Key]
public int ConsultaID { get; set; }

[Column(TypeName = "date")] //só regista 'datas', não 'horas'
public DateTime DataConsulta { get; set; }


[ForeignKey("Veterinario")]
public int VeterinarioFK { get; set; }
public virtual Veterinarios Veterinario { get; set; }


[ForeignKey("Animal")]
public int AnimalFK { get; set; }
public virtual Animais Animal { get; set; }


