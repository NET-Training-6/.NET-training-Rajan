//Create a room class with at least 4 fields and two methods where;
//first method takes no parameter and return some value
//second method shpould return value and takes two parameter
//Caller should be able to create objects/instances of this class as follows;
//var room1 = new Room();
// var room2 = nerRoom(provide all 4 data fields);

//using System;
class Room
{
  public int roomId;
  public string roomBookedBy;
  public DateTime startdatetime;
  public DateTime enddatetime;

// default constructor
  public Room()
  {

  }

//parametrize constructor
 public Room(int roomId = 89, string roomBookedBy ="Sanjiv")
 {
    this.roomId = roomId;
    this.roomBookedBy = roomBookedBy;
    this.startdatetime = DateTime.Now;
    this.enddatetime = DateTime.Now.AddDays(4);
}

public string UpdateOwner(string roomBookedBy)
{
    this.roomBookedBy = roomBookedBy;
    return roomBookedBy;
}
public string getOwner()
{
    return this.roomBookedBy;
}
public string UpdateBookingDateTime(DateTime fromDate, DateTime toDate)
{
    this.startdatetime = fromDate;
    this.enddatetime = toDate;
    return $"Room{this.roomId} has been booked by from {fromDate} to {toDate}";
}
 public string PrintMessage() =>  $"Room {this.roomId} has been booked by {this.roomBookedBy}, and booking time has been updated from {this.startdatetime} to {this.enddatetime}";
 
}

