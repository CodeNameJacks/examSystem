using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examSystem.Models;

public class Questions
{
    public int Id { get; set; }
    public required string Subject {get; set;}
    public required string ExamQuestion{ get; set; }
    public required string AnswerOption { get; set; }
    public required string CorrectAnswer { get; set; }

    public Questions()
    {
        //constructor
    }
}
