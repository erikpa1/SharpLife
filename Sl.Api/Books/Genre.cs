

using System.ComponentModel.DataAnnotations;

public record Genre
{

    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }



}

public record SubGenre
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }


}


public record Topic
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }


}

public record Category
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }


}


/*

Claude suggestions

Genre
├── Fiction
└── Nonfiction

SubGenre
├── Documentary
├── Biography
├── Autobiography / Memoir
├── Historical Fiction
├── Science Fiction
├── Fantasy
├── Thriller
├── Mystery
├── Romance
├── Horror
└── Adventure

Category
├── History
├── Science
├── Technology
├── Politics
├── Nature
├── Society
├── Business
├── Philosophy
└── Psychology

Topic
├── World War II
├── Artificial Intelligence
├── Wildlife
├── Space Exploration
├── Cybercrime
└── Ancient Rome

*/
