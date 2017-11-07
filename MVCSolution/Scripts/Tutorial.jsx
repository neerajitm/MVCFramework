
var data = [
  { Author: "Daniel Lo Nigro", Text: "Hello ReactJS.NET World!" },
  { Author: "Pete Hunt", Text: "This is one comment" },
  { Author: "Jordan Walke", Text: "This is *another* comment" }
];

var CommentBox = React.createClass({
    render: function () {
        return (
      <div className="commentBox">
              <h1>Comments</h1>
               <CommentList data={this.props.data} />
      </div>
    );
    }
});

//ReactDOM.render(
//  /
//  document.getElementById('content')
//);


//var CommentBox = React.createClass({
//    displayName: 'CommentBox',
//    render: function () {
//        return (
//              React.createElement('div', { className: "commentBox" }, "Hello, World i am Commentbox.")
//              );
//    }
//});

var CommentList = React.createClass({
    render: function () {
        var commentNodes = this.props.data.map(function (comment) {
            return
            (
               <Comment author={comment.Author}>
                   {comment.Text}
               </Comment>
            );
        });

        return (   <div className="commentList">
                     <commentNodes />
           </div>
            );
    }
});

var CommentForm = React.createClass({
    render: function () {
        return
        (
          <div className="commentForm">
              Hello,world! I am a CommentForm.
          </div>
        );
    }
});


var Comment = React.createClass({
    render: function () {
        var convertor = new Showdown.converter();
        return (
         <div className="comment">
             <h2 className="commentAuthor">
                 {this.props.author}
             </h2>
             {convertor.makeHtml(this.props.children.toString())}
         </div>
        );
    }
});



ReactDOM.render(
  <CommentBox data={data} />,
  //React.createClass(CommentBox,null),
  document.getElementById('content')
);
