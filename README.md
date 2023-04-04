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
git config --global user.name "ZiganshinIB"
git config --global user.email "elzig3012@gmail.com"
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

.

```bash
git mv <old name> <new name>
```
