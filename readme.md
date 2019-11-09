# 弹幕姬

Windows端采用WPF程序框架，界面语言为XAML（一种XML语言），后台语言为C#，主要负责逻辑交互以及网络连接等问题。程序主要有三个界面：main界面、设置界面以及弹幕界面。

## main界面

main界面其实是采用复用形式，即通过按程序内的不同按钮改变屏幕上的控件的visibility（可见性）属性，从而达到一种看似是发生页面切换实则只有一个页面文件的效果。

如图1为初始界面，用户可以选择直接创建临时房间（即游客登录）和利用账户密码登录。

![1.png](https://i.loli.net/2019/11/09/EzJq6wQVjUCM1fB.png)

图2、图3为点击主页面的创建临时房间后依次经历的页面。用户输入完临时房间后便可创建一个临时房间。

![2.png](https://i.loli.net/2019/11/09/w4er9GHXQY7AaVR.png)
![3.png](https://i.loli.net/2019/11/09/8E6gyJhb1FO7WNx.png)

图4、5为用户点击初始页面的账号密码登录按钮后依次经历的页面。用户登录后便可以从服务器获取他以前创立的房间列表。

![4.png](https://i.loli.net/2019/11/09/pLneOymhbwvZG41.png)
![5.png](https://i.loli.net/2019/11/09/wIXDlp3EOG9BqRm.png)

## 设置界面

图6为程序设置页面，主要是设置程序的主题样式。

![6.png](https://i.loli.net/2019/11/09/KHqYO6h5agMVzpF.png)

## 弹幕页面

弹幕页面是设置成透明、最大化且始终保持窗口最前，如此才能达到最好的弹幕效果。
