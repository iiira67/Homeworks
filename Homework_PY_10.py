# В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего из 1 столбца. Ваша задача перевести его в one hot вид. Сможете ли вы это сделать без get_dummies?
import pandas as pd
import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})
data.head()

uniq_values = data['whoAmI'].unique()
one_hot_data = pd.DataFrame()
for i in uniq_values:
    one_hot_data[i] = (data['whoAmI'].unique() == i).astype(int)
one_hot_data.head()
print(data)    
