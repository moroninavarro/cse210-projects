using System;
using System.Transactions;

public class Video {

    static Comment comentarios = new Comment("", "");
    private List<Comment> _comment;


    public string _title;
    public string _author;
    public int _seconds;

   // Each video also has responsibility to store a list of comments, and should have 
   //a method to return the number of comments. 
   

   public Video(){
    _comment = new List<Comment>();
   }

   public void AddComment(Comment comment){
    _comment.Add(comment);
   }

   public int NumComments(){
    return _comment.Count;
   }
}