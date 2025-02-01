using System;
using System.Transactions;

public class Video {

   
    
    private List<Comment> _comment;


    public string _title;
    public string _author;
    public int _seconds;

   // Each video also has responsibility to store a list of comments, and should have 
   //a method to return the number of comments. 
   
    public Video(string title, string author, int seconds){
        _title = title;
        _author= author;
        _seconds = seconds;
        _comment = new List<Comment>();
    }


    
    public string TheComment(){
       string result = "";
       foreach(Comment comentario in _comment)
       {
        result += comentario.DisplayCommentAndName() + Environment.NewLine;
       }

        return result;
        
    }


    //This will help me to have the number of comments in the future.
    

    public void AddComment(Comment comment){
        if (_comment== null)
        {
            _comment = new List<Comment>();
        }
     _comment?.Add(comment);
    }

   public int NumComments(){
    return _comment.Count;
   }
}