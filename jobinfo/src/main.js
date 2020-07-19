// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'

Vue.config.productionTip = false

import { Tabbar, TabbarItem } from 'vant';
import { NavBar } from 'vant';
import { Search } from 'vant';
import { Sticky } from 'vant';
import { Cell, CellGroup } from 'vant';
import { PullRefresh } from 'vant';
import { List } from 'vant';
import { Toast } from 'vant';
import { Image } from 'vant';
import { Button } from 'vant';
import { Icon } from 'vant';
import { Panel } from 'vant';
import { Divider } from 'vant';
import { Lazyload } from 'vant';
import { Swipe, SwipeItem } from 'vant';

Vue.use(Tabbar).use(TabbarItem).use(NavBar).use(Search).use(Sticky).use(Cell).use(CellGroup).use(PullRefresh).use(List).use(Toast).use(Image).use(Button).use(Icon).use(Panel).use(Divider).use(Swipe).use(SwipeItem);
Vue.use(Lazyload, {
  lazyComponent: true
});

//全局ajax
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios);

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
