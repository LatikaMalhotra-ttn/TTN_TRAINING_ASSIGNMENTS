import reducer from './auth'
import * as actionTypes from '../actions/actionTypes'

describe('auth reducer',()=>{
    it('should return the initial state',()=>{
        expect(reducer(undefined,{})).toEqual({
            token:null,
            userId:null,
            error:null,
            loading:false,
            authRedirectPath:'/'
        });
    });

    it('shoild store the token on Login',()=>{
        expect(reducer({
            token:null,
            userId:null,
            error:null,
            loading:false,
            authRedirectPath:'/'
        },
        {
            type:actionTypes.AUTH_SUCCESS,
            idToken:"some-token",
            userId:"Some-userId"

        })).toEqual({
            token:"some-token",
            userId:"Some-userId",
            error:null,
            loading:false,
            authRedirectPath:'/'
        })
    })
})