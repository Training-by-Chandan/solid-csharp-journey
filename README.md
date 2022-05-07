# solid-csharp-journey

# Git commands
## Basic
1. Initialize Empty Repository : **git init**
2. Check the status of the working directory : **git status**
3. Add files to the staging area : **git add {{ . | filename }}**
4. Commit changes : **git commit -m {{messages}}**
5. Push changes to a remote repository : **git push {{origin}} {{branch name}}**
6. Pull changes from a remote repository : **git pull {{origin}} {{branch name}}**
7. Clone a remote repository : **git clone**
8. View the history of a file : **git log {{filename}}**
9. View the history of a file : **git log --stat {{file name}}**

## Configuration Commands
1. Set user name and email : **git config --global user.name "Your Name"**
2. Set user name and email : **git config --global user.email "Your Email"**

## Remote Commands
1. View the status of a remote repository : **git remote**
2. View the status of a remote repository : **git remote show**
3. Add Remote Repository : **git remote add {{origin}} {{url}}**
4. Detailed information of remote repository : **git remote show {{origin}}**
