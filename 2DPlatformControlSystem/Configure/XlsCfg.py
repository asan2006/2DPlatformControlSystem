import os
filePaths = []
for line in open("文件路径.txt"):
    filePaths.append(line.strip("\n"))
    #print(filePaths)

for path in filePaths:
    listFile = os.listdir(path)
    for file in listFile:
        if os.path.isfile(path + "\\" + file):
            # 判断是xls类型的配置文件
            if os.path.splitext(file)[1] in [".xlsx",".xls"]:
                print("YES")
            else:
                print("NO")
            #print(file)
