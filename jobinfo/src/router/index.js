import Vue from 'vue'
import Router from 'vue-router'
import index from '@/components/index'
import more from '@/components/more'
import info from '@/components/info'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'index',
      component: index,
      meta: {
        navShow: true,//是否显示底部导航栏
        keepAlive: true, //此组件需要被缓存,
      }
      // children: [
      //   {
      //     path: '/info',
      //     name: 'info',
      //     component: info 
      //   }]
    }, {
      path: '/more',
      name: 'more',
      component: more,
      meta: {
        navShow: true,//是否显示底部导航栏
        keepAlive: true, //此组件需要被缓存
      },
    }
    , {
      path: '/info',
      name: 'info',
      component: info,
      meta: {
        navShow: false,//是否显示底部导航栏
        keepAlive: false, //此组件不需要被缓存
      },
    }

  ]
})
