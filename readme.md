#new project --> dotnet new console -n PROJECT_NAME

#run command --> dotnet run

#run command --> cd "/Users/ratul/Code/C sharp/ptc6" && dotnet run

#delete a folder --> git rm -r foldername

#delete folder but keep locally --> git rm -r --cached OldFolder

#If you start a new project locally, make sure to connect it once:
git remote add origin https://github.com/abeerscode/C-sharp.git

#Commit and Push

1. cd C-sharp ---> Go to main repo
2. git remote -v ---> Make sure it’s linked
3. git add . ---> Stage your new project
4. git commit -m "comments anything" ---> Save commit
5. git push origin main ---> Upload to GitHub

#Always clone your GitHub repo instead of manually creating a folder:
git clone https://github.com/<username>/<repo>.git
