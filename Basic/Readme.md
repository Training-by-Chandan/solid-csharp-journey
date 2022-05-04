# Git commands
## Basic
1. Initialize Empty Repository : **git init**
1. Check the status of the working directory : **git status**
1. Add files to the staging area : **git add {{ . | filename }}**
1. Commit changes : **git commit -m {{messages}}**
1. Push changes to a remote repository : **git push {{origin}} {{branch name}}**
1. Pull changes from a remote repository : **git pull {{origin}} {{branch name}}**
1. Clone a remote repository : **git clone**
1. View the history of a file : **git log {{filename}}**
1. View the history of a file : **git log --stat {{file name}}**

## Configuration Commands
1. Set user name and email : **git config --global user.name "Your Name"**
2. Set user name and email : **git config --global user.email "Your Email"**

## Remote Commands
9. View the status of a remote repository : **git remote**
10. View the status of a remote repository : **git remote show**
1. Add Remote Repository : **git remote add {{origin}} {{url}}**
1. Detailed information of remote repository : **git remote show {{origin}}**

