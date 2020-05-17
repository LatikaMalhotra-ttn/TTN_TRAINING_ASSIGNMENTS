import React from 'react'
import {configure,shallow} from 'enzyme';
import Adapter from 'enzyme-adapter-react-16'
import NavigationItems from './NavigationItems'
import NavigationItem from './NavigationItem/NavigationItem'

configure({adapter:new Adapter()})

describe('<navigationItem/>',()=>{

    let wrapper;
    beforeEach(()=>{
        wrapper=shallow(<NavigationItems/>);
    })
    it('should render two <navigationItems/> elemennt if not authentiated',()=>{
        
        expect(wrapper.find(NavigationItem)).toHaveLength(2);
    });

    it('should render three <navigationItems/> elemennt if authentiated',()=>{
        wrapper.setProps({isAuthenticated:true});
        expect(wrapper.find(NavigationItem)).toHaveLength(3);
    });


    it('should an exact logout button',()=>{
        wrapper.setProps({isAuthenticated:true});
        expect(wrapper.contains(<NavigationItem link="/logout">Logout</NavigationItem>)).toEqual(true);
    });
})