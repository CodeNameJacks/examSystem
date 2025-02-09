using System;

namespace examSystem.Models;

public class Science
{
    public int Id { get; set; }
    public required string Question { get; set; }
    public required string AnswerOption { get; set; }
    public required string CorrectAnswer { get; set; }

}
