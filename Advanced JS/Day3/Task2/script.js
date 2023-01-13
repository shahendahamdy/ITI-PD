/* 
create Box :content Book Book
    fun :getCount of books 
    deleteBook(title)
    No two books have same name or title
    toString()disply all books sorted by 
            :: disply books dimensions
    ValueOf() return number of books in the boxes
        box1+box2

create book
    class prop :getCount all the books 

no inheritance use global var
 */
//Create your box object that contains books objects
function Box(_height, _width, _length, _material) {
  this.Height = _height;
  this.Width = _width;
  this.Length = _length;
  this.Material = _material;
  this.Content = []; //Array of objects
}
//Box1 + Box2 +.. num of books in all boxes
Box.prototype.totalContentOfBoxes = 0;

//Create book object and add it to box object content
function Book(
  _title,
  _numofChapters,
  _author,
  _numofPages,
  _publisher,
  _numofCopies
) {
  Book.prototype.booksCounter++;
  this.Title = _title;
  this.NumofChapters = _numofChapters;
  this.Author = _author;
  this.NumofPages = _numofPages;
  this.Publisher = _publisher;
  this.NumofCopies = _numofCopies;
}

//Count # of books inside box
Box.prototype.numOfBooks = function () {
  return this.Content.length;
};

//Add book
Box.prototype.addBook = function (book) {
  this.Content.push(book);
  Box.prototype.totalContentOfBoxes++;
};

//Delete any of these books in box according to book title.
//Note: You should delete a single copy of the books with the same title.
Box.prototype.deleteBookByTitle = function (title) {
  for (var i = 0; i < this.Content.Length; i++) {
    if (this.Content[i].Title == title) {
      break;
    }
  }
  if (i == this.Content.Length) throw "Not found";
  else {
    this.Content.splice(i, 1);
    console.log("item removed successfully");
    Box.prototype.totalContentOfBoxes--;
  }
};

//Create Class Property that counts numbers of created books objects and Class method to retrieve it.
Book.prototype.booksCounter = 0;
Book.prototype.getCounter = function () {
  return this.booksCounter;
};

//Use .toString() to display the box instance’s dimensions and how books are stored in it.
Box.prototype.toString = function () {
  return (
    "Height = " +
    this.Height +
    ", Width = " +
    this.Width +
    ", Length = " +
    this.Length +
    ", Material = " +
    this.Material +
    ",  BooksCounter : " +
    this.numOfBooks()
  );
};
var box1 = new Box(50, 50, 50, "Wood");

var book1 = new Book("history", 2, "x1", 100, "y1", 50);
var book2 = new Book("science", 2, "x2", 100, "y2", 50);
var book3 = new Book("html", 2, "x2", 100, "y2", 50);
var book4 = new Book("css", 2, "x2", 100, "y2", 50);
var book5 = new Book("js", 2, "x2", 100, "y2", 50);

box1.addBook(book1);
box1.addBook(book2);
box1.addBook(book3);
box1.addBook(book4);
box1.addBook(book5);

var box2 = new Box(100, 100, 100, "metal");
var book6 = new Book("c", 2, "x2", 100, "y2", 50);
var book7 = new Book("c++", 2, "x2", 100, "y2", 50);

box2.addBook(book6);
box2.addBook(book7);
