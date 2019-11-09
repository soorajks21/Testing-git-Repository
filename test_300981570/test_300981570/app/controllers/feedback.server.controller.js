exports.render = function (req, res) {
    var session = req.session;
    if (session.username) {
        res.render('student', {
            title: "student-form",
            emailSession: session.username
        });
    }
    else 
    {
        res.render('login', {});
    }
};