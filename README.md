# Конфигурация Git

Используется для конфигурации используется комманда 

```bash
git config 
```

Настройки делятся: 

```bash
git config --system <config>
git config --global <config>
git config --local <config>
```

В первую очередь срабатывает локальные настройки потом глобальные и в конце системные 

Для удаление каких либо настроек воспользуйся

```bash
git config --remove-section <section>
git config --unset <config>
```

Пример:

```bash
git config --global user.name "Denis"
git config --global user.email "denisberezovski@mail.ru"
git config --global --unset user.name
git config --global --remove-section user
```

для просмотра основных команд пользуся git config -h или git help <команда>

# Alias

Alias- это быстрая команда, script или по другому сокрощенная команда

Если у вас есть команды, которые часто повторяются то лучше для него задать Alias

Пример:

```bash
git config --global alias.<Краткая комнда> '<comanda>'
git config --global alias.cn 'config user.name'

git config --global alias.st '!init ; touch readme.md; touch .gitignore'
```
# Для работы с проектом

Для начало воспользуетесь командой 

```bash
git init 
```

Система сохранения git 2 ступенчетая 

Index - хранить список файлов для отслеживания. Добавляется командой

```bash
git add <file>
git add -p <file>
```

Repository - хранить всю историю проекта. Добавляется командой

```bash
git commit 
```

Первая строка это короткая комментария 2 оставьте пустой потом детали

```bash
Hello!

* fix  file 
* Create file 
```

# Просмотр commit

Для просмотра commit:

```bash
git show <identificator>
```

Автор - тот кто написал код, автор может не имет права на сохранение в репозиторю

Commit - это тот кто создал commit, сохранил в репозиторю

для указание автора 

```bash
git commit --author="Diana Sadykova <dina@gmail.com>" --date='...'
```

# Добавление файлов

Git не умеет работать с пустыми папками для этого в папке создают пустой файл .gitkeep

git status  - возвращает статус отслеживании 

Если нам необходимо сбросить от отслеживании какие-то файлы

```bash
git reser HEAD <file>
```

# Gitignore

если вы не хотите отслеживать некоторые файлы и директории то создайте файл .gitignore и пропишите все пути которые не надо будет отслеживать

ну если вам необходимо добавить какойте файл из игнорируемой директории:

```bash
git add -f <file>
```

# Хороший коммит

Делайте 1 коммит для одного изменении. Комиты должны быть атомарными 

*Commit early. Commit often.*

Стиль комита 

<Характер коммита>(компонент): <деталь>

***Характеры коммита*** 

- feat - добавлена возможность
- test - работа над тестированием
- build - работа над сборкой
- refactor - изменение кода
- fix - исправление ошибок

***Компонент - часть проекта в котором была произведена работа*** 

# Сохранить быстро

```bash
git commite -am "Comment" 
git commite -a 
git commite -m 'Comment' .gitignore
git config --global alias.commitall '!git add -A; git commit'
```

# Удаление файлов

```bash
git rm <file>
git rm -r <dir>

git rm -r --cached <dir> # удалить из индекса 

--cached # работы производится с индексам 
```

переименование - для git это удаление и создание нового файла

```bash
git mv <old name> <new name>
```
# Ветки

# Создание и переключения

Когда вы комитете git создает ветку по умолчанию master. Ветка это специальная ссылка на коммит .git/refs/heads

```bash
git branch
git branch -v
```

HEAD используется для того чтобы мы понимали где находимся сейчас 

для создание новой ветки 

```bash
git branch feature
```

переключения 

```bash
git checkout feature
```

2 в одном 

```bash
git checkout -b feature
```

# Checkout при незакоммиченных изменениях

Если вам надо срочно надо произвести переключения, но если вам не надо сохронят

```bash
git checkout -f <Ветка>
git checkout -f HEAD - для удаления изменении
```

Но если вам необходимо сохранить незаконченные изменение то

```bash
git stash # временно сохраняем
git checkout <Веткка> # переключаемся
# ............................................
git checkout featur # обратно возвращаемся
git stash pop

```

# Перенос веток “вручную”

```bash
git branch master <commit_hashcode> # Создать ветку в комите 
git branch -f master <commit_hashcode> # Создать если нет иначе перемистить

git checkout -B master <commit_hashcode> # тоже самое что и выше, но и HEAD меняется

```

# Состояние отделенной HEAD

Если вы делайте так 

```bash
git checkout <commit_hashcode>
```

то HEAD не будет ссылаться на ветку 

Гит со временем удаляет эти комиты 

Если вы хотите этот комит пременит на текущую ветку то команда 

```bash
git cherry-pick <commit_hashcode>
```

# Восстановление предыдущих версий файлов

Получить указанный файл на момент переданного комита, но оно добавляеть эти файлы в индекс

```bash
git checkout <id или ветка> <path>
```

Убрать из индекса

```bash
git reset <path>
```

Если вы хотите удалить последние изменении в файле

```bash
git checkout -- <path>
```

# Просмотр истории и старых файлов

```bash
git log
git log --oneline
```

По умолчанию git log выводить ветку с HEAD

```bash
git log <ветка> --oneline
```

Для просмотра commit и иззменении в файле

```bash
git show <id или ветка>
```

для просмотра родителя используй тилду (~)

```bash
git show HEAD~

git show HEAD~~

git show HEAD~~ --quiet

git show HEAD~3 # = git show HEAD~~~ = git show @~~~

git show @~:index.html # получим файл

git show :/<Что искать?>
```

# Слияние веток “перемоткой”

```bash
git merge <ветка или id>
```

откать слиянии

```bash
git branch -f master <id>

git branch -f master ORIG_HEAD

```

# Удаление веток

```bash
git branch -d <ветка>
```

но это сработает только в случае если ветка объядена с другой веткой, то есть ссылаются на 1 коммит

```bash
git branch -D <Ветка> # крайне не рекомендуется
```

# История переключений веток: лог ссылок reflog

```bash
git reflog 

git reflog <ветка>
```

# Урок 2. Работа с изменениями
Данное домашнее задание является продолжением домашнего задания, которое вы выполняли на предыдущем семинаре в репозитории с собственным проектом.

1. Просмотрите историю коммитов в своём проекте и выберите три случайных коммита. Просмотрите изменения, которые были в них сделаны.

2. Верните эти изменения командой git revert последовательно, чтобы в итоге получилось тоже три коммита.

3. Попробуйте отменить эти три коммита:
* последний — командами git reset --soft и git restore;
* предпоследний — командой git reset --mixed и git restore;
* первый — командой git reset --hard.


test1

test2